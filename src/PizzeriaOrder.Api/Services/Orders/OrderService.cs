using Microsoft.EntityFrameworkCore;
using PizzeriaOrder.Api.Data;
using PizzeriaOrder.Api.DTOs.Orders;
using PizzeriaOrder.Api.Models.Orders;
using PizzeriaOrder.Api.Services.Email;

namespace PizzeriaOrder.Api.Services.Orders;

public class OrderService : IOrderService
{
    private readonly PizzeriaDbContext _dbContext;
    private readonly IEmailService _emailService;

    public OrderService(PizzeriaDbContext dbContext, IEmailService emailService)
    {
        _dbContext = dbContext;
        _emailService = emailService;
    }
    

    public async Task<OrderDto> CreateOrderAsync(
        CreateOrderDto dto,
        CancellationToken cancellationToken = default)
    {
        var restaurantExists = await _dbContext.Restaurants
            .AnyAsync(
                r => r.Id == dto.RestaurantId && r.IsActive,
                cancellationToken);

        if (!restaurantExists)
        {
            throw new InvalidOperationException(
                "Restaurangen finns inte eller är inte aktiv.");
        }

        if (dto.Items.Count == 0)
        {
            throw new InvalidOperationException(
                "Beställningen måste innehålla minst en vara.");
        }

        var order = new Order
        {
            RestaurantId = dto.RestaurantId,
            CustomerName = dto.CustomerName.Trim(),
            Phone = dto.Phone.Trim(),
            Email = string.IsNullOrWhiteSpace(dto.Email)
                ? null
                : dto.Email.Trim(),
            Comment = string.IsNullOrWhiteSpace(dto.Comment)
                ? null
                : dto.Comment.Trim(),
            Status = "New",
            CreatedAtUtc = DateTime.UtcNow
        };

        decimal orderTotal = 0m;

        foreach (var itemDto in dto.Items)
        {
            if (itemDto.Quantity <= 0)
            {
                throw new InvalidOperationException(
                    "Antal måste vara minst 1.");
            }

            var menuItem = await _dbContext.MenuItems
                .AsNoTracking()
                .Include(i => i.Variants)
                .Include(i => i.Extras)
                .FirstOrDefaultAsync(
                    i => i.Id == itemDto.MenuItemId &&
                         i.MenuCategory.RestaurantId == dto.RestaurantId &&
                         i.IsActive,
                    cancellationToken);

            if (menuItem is null)
            {
                throw new InvalidOperationException(
                    $"Menyartikeln {itemDto.MenuItemId} finns inte.");
            }

            decimal unitPrice;

            OrderItemVariant? selectedVariant = null;

            if (itemDto.MenuItemVariantId.HasValue)
            {
                var variant = menuItem.Variants
                    .FirstOrDefault(v =>
                        v.Id == itemDto.MenuItemVariantId.Value &&
                        v.IsActive);

                if (variant is null)
                {
                    throw new InvalidOperationException(
                        $"Ogiltigt variantval för {menuItem.Name}.");
                }

                unitPrice = variant.Price;

                selectedVariant = new OrderItemVariant
                {
                    MenuItemVariantId = variant.Id,
                    Name = variant.Name,
                    Price = variant.Price
                };
            }
            else
            {
                if (!menuItem.Price.HasValue)
                {
                    throw new InvalidOperationException(
                        $"{menuItem.Name} kräver att en variant väljs.");
                }

                unitPrice = menuItem.Price.Value;
            }

            var orderItem = new OrderItem
            {
                MenuItemId = menuItem.Id,
                Name = menuItem.Name,
                Quantity = itemDto.Quantity,
                UnitPrice = unitPrice,
                Comment = string.IsNullOrWhiteSpace(itemDto.Comment)
                    ? null
                    : itemDto.Comment.Trim()
            };

            if (selectedVariant is not null)
            {
                orderItem.Variant = selectedVariant;
            }

            decimal extrasTotal = 0m;

            foreach (var extraId in itemDto.MenuItemExtraIds.Distinct())
            {
                var extra = menuItem.Extras
                    .FirstOrDefault(e =>
                        e.Id == extraId &&
                        e.IsActive);

                if (extra is null)
                {
                    throw new InvalidOperationException(
                        $"Ogiltigt tillval för {menuItem.Name}.");
                }

                orderItem.Extras.Add(
                    new OrderItemExtra
                    {
                        MenuItemExtraId = extra.Id,
                        Name = extra.Name,
                        PriceChange = extra.PriceChange
                    });

                extrasTotal += extra.PriceChange;
            }

            var itemTotal =
                (unitPrice + extrasTotal) * itemDto.Quantity;

            orderItem.TotalPrice = itemTotal;

            order.Items.Add(orderItem);

            orderTotal += itemTotal;
        }

        order.TotalPrice = orderTotal;

        _dbContext.Orders.Add(order);

        await _dbContext.SaveChangesAsync(cancellationToken);

        if (!string.IsNullOrWhiteSpace(order.Email))
        {
            try
            {
                await _emailService.SendOrderConfirmationAsync(
                    order,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Kunde inte skicka orderbekräftelse för order {order.Id}: {ex.Message}");
            }
        }

        return MapOrder(order);
    }

    public async Task<OrderDto?> GetOrderAsync(
        int orderId,
        CancellationToken cancellationToken = default)
    {
        var order = await _dbContext.Orders
            .AsNoTracking()
            .Include(o => o.Items)
                .ThenInclude(i => i.Variant)
            .Include(o => o.Items)
                .ThenInclude(i => i.Extras)
            .FirstOrDefaultAsync(
                o => o.Id == orderId,
                cancellationToken);

        return order is null
            ? null
            : MapOrder(order);
    }

    public async Task<OrderDto?> UpdateOrderStatusAsync(
    int orderId,
    string status,
    CancellationToken cancellationToken = default)
    {
        var allowedStatuses = new[]
        {
            "New",
            "Confirmed",
            "Preparing",
            "ReadyForPickup",
            "Collected",
            "Rejected",
            "Cancelled"
        };

        var normalizedStatus = allowedStatuses
            .FirstOrDefault(s =>
                s.Equals(
                    status?.Trim(),
                    StringComparison.OrdinalIgnoreCase));

        if (normalizedStatus is null)
        {
            throw new InvalidOperationException(
                "Ogiltig orderstatus.");
        }

        var order = await _dbContext.Orders
            .Include(o => o.Items)
                .ThenInclude(i => i.Variant)
            .Include(o => o.Items)
                .ThenInclude(i => i.Extras)
            .FirstOrDefaultAsync(
                o => o.Id == orderId,
                cancellationToken);

        if (order is null)
        {
            return null;
        }

        order.Status = normalizedStatus;

        await _dbContext.SaveChangesAsync(cancellationToken);

        if (!string.IsNullOrWhiteSpace(order.Email))
        {
            try
            {
                await _emailService.SendOrderStatusEmailAsync(
                    order,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Kunde inte skicka statusmejl för order {order.Id}: {ex.Message}");
            }
        }

        return MapOrder(order);
    }

    private static OrderDto MapOrder(Order order)
    {
        return new OrderDto
        {
            Id = order.Id,
            RestaurantId = order.RestaurantId,
            CustomerName = order.CustomerName,
            Phone = order.Phone,
            Email = order.Email,
            Comment = order.Comment,
            TotalPrice = order.TotalPrice,
            Status = order.Status,
            CreatedAtUtc = order.CreatedAtUtc,

            Items = order.Items
                .Select(i => new OrderItemDto
                {
                    Id = i.Id,
                    MenuItemId = i.MenuItemId,
                    Name = i.Name,
                    Quantity = i.Quantity,
                    UnitPrice = i.UnitPrice,
                    TotalPrice = i.TotalPrice,
                    Comment = i.Comment,

                    Variant = i.Variant is null
                        ? null
                        : new OrderItemVariantDto
                        {
                            Id = i.Variant.Id,
                            MenuItemVariantId =
                                i.Variant.MenuItemVariantId,
                            Name = i.Variant.Name,
                            Price = i.Variant.Price
                        },

                    Extras = i.Extras
                        .Select(e => new OrderItemExtraDto
                        {
                            Id = e.Id,
                            MenuItemExtraId = e.MenuItemExtraId,
                            Name = e.Name,
                            PriceChange = e.PriceChange
                        })
                        .ToList()
                })
                .ToList()
        };
    }
    public async Task<List<OrderDto>> GetOrdersForRestaurantAsync(
        int restaurantId,
        string? status = null,
        CancellationToken cancellationToken = default)
    {
        var query = _dbContext.Orders
            .AsNoTracking()
            .Where(o => o.RestaurantId == restaurantId)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(status))
        {
            query = query.Where(o => o.Status == status);
        }

        var orders = await query
            .Include(o => o.Items)
                .ThenInclude(i => i.Variant)
            .Include(o => o.Items)
                .ThenInclude(i => i.Extras)
            .OrderByDescending(o => o.CreatedAtUtc)
            .ToListAsync(cancellationToken);

        return orders
            .Select(MapOrder)
            .ToList();
    }

    public async Task<List<OrderDto>> GetActiveOrdersForRestaurantAsync(
        int restaurantId,
        CancellationToken cancellationToken = default)
    {
        var activeStatuses = new[]
        {
            "New",
            "Confirmed",
            "Preparing",
            "ReadyForPickup"
        };

        var orders = await _dbContext.Orders
            .AsNoTracking()
            .Where(o =>
                o.RestaurantId == restaurantId &&
                activeStatuses.Contains(o.Status))
            .Include(o => o.Items)
                .ThenInclude(i => i.Variant)
            .Include(o => o.Items)
                .ThenInclude(i => i.Extras)
            .OrderByDescending(o => o.CreatedAtUtc)
            .ToListAsync(cancellationToken);

        return orders
            .Select(MapOrder)
            .ToList();
    }
}