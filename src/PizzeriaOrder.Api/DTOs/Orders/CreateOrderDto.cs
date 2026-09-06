namespace PizzeriaOrder.Api.DTOs.Orders;

public class CreateOrderDto
{
    public int RestaurantId { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string? Email { get; set; }

    public string? Comment { get; set; }

    public List<CreateOrderItemDto> Items { get; set; } = [];
}