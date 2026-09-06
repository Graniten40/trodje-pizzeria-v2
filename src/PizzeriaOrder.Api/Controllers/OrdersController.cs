using Microsoft.AspNetCore.Mvc;
using PizzeriaOrder.Api.DTOs.Orders;
using PizzeriaOrder.Api.Services.Orders;

namespace PizzeriaOrder.Api.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(
        CreateOrderDto dto,
        CancellationToken cancellationToken)
    {
        try
        {
            var order = await _orderService.CreateOrderAsync(
                dto,
                cancellationToken);

            return CreatedAtAction(
                nameof(GetOrder),
                new { orderId = order.Id },
                order);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new
            {
                message = ex.Message
            });
        }
    }

    [HttpGet("{orderId:int}")]
    public async Task<IActionResult> GetOrder(
        int orderId,
        CancellationToken cancellationToken)
    {
        var order = await _orderService.GetOrderAsync(
            orderId,
            cancellationToken);

        if (order is null)
        {
            return NotFound(new
            {
                message = "Beställningen hittades inte."
            });
        }

        return Ok(order);
    }

    [HttpPatch("{orderId:int}/status")]
    public async Task<IActionResult> UpdateStatus(
        int orderId,
        UpdateOrderStatusDto dto,
        CancellationToken cancellationToken)
    {
        try
        {
            var order = await _orderService.UpdateOrderStatusAsync(
                orderId,
                dto.Status,
                cancellationToken);

            if (order is null)
            {
                return NotFound(new
                {
                    message = "Beställningen hittades inte."
                });
            }

            return Ok(order);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new
            {
                message = ex.Message
            });
        }
    }

    [HttpGet("/api/restaurants/{restaurantId:int}/orders")]
    public async Task<IActionResult> GetOrdersForRestaurant(
        int restaurantId,
        [FromQuery] string? status,
        CancellationToken cancellationToken)
    {
        var orders = await _orderService.GetOrdersForRestaurantAsync(
            restaurantId,
            status,
            cancellationToken);

        return Ok(orders);
    }

    [HttpGet("/api/restaurants/{restaurantId:int}/orders/active")]
    public async Task<IActionResult> GetActiveOrdersForRestaurant(
        int restaurantId,
        CancellationToken cancellationToken)
    {
        var orders =
            await _orderService.GetActiveOrdersForRestaurantAsync(
                restaurantId,
                cancellationToken);

        return Ok(orders);
    }
}