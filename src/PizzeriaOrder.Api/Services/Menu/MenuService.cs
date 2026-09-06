using Microsoft.EntityFrameworkCore;
using PizzeriaOrder.Api.Data;
using PizzeriaOrder.Api.DTOs.Menu;

namespace PizzeriaOrder.Api.Services.Menu;

public class MenuService : IMenuService
{
    private readonly PizzeriaDbContext _dbContext;

    public MenuService(PizzeriaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<MenuCategoryDto>> GetMenuAsync(
        int restaurantId,
        CancellationToken cancellationToken = default)
    {
        return await _dbContext.MenuCategories
            .AsNoTracking()
            .Where(c =>
                c.RestaurantId == restaurantId &&
                c.IsActive)
            .OrderBy(c => c.SortOrder)
            .Select(c => new MenuCategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                SortOrder = c.SortOrder,

                Items = c.MenuItems
                    .Where(i => i.IsActive)
                    .OrderBy(i => i.SortOrder)
                    .Select(i => new MenuItemDto
                    {
                        Id = i.Id,
                        Name = i.Name,
                        Description = i.Description,
                        Price = i.Price,
                        ImageUrl = i.ImageUrl,

                        Variants = i.Variants
                            .Where(v => v.IsActive)
                            .OrderBy(v => v.SortOrder)
                            .Select(v => new MenuVariantDto
                            {
                                Id = v.Id,
                                Name = v.Name,
                                Price = v.Price
                            })
                            .ToList(),

                        Extras = i.Extras
                            .Where(e => e.IsActive)
                            .OrderBy(e => e.SortOrder)
                            .Select(e => new MenuExtraDto
                            {
                                Id = e.Id,
                                Name = e.Name,
                                PriceChange = e.PriceChange
                            })
                            .ToList()
                    })
                    .ToList()
            })
            .ToListAsync(cancellationToken);
    }
}