using PizzeriaOrder.Api.DTOs.Orders;

namespace PizzeriaOrder.Api.Services.Orders;

public interface IOrderService
{
    Task<OrderDto> CreateOrderAsync(
        CreateOrderDto dto,
        CancellationToken cancellationToken = default);

    Task<OrderDto?> GetOrderAsync(
        int orderId,
        CancellationToken cancellationToken = default);

    Task<OrderDto?> UpdateOrderStatusAsync(
        int orderId,
        string status,
        CancellationToken cancellationToken = default);

    Task<List<OrderDto>> GetOrdersForRestaurantAsync(
        int restaurantId,
        string? status = null,
        CancellationToken cancellationToken = default);

    Task<List<OrderDto>> GetActiveOrdersForRestaurantAsync(
        int restaurantId,
        CancellationToken cancellationToken = default);
}