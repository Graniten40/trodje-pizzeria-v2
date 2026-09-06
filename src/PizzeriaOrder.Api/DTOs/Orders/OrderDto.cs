namespace PizzeriaOrder.Api.DTOs.Orders;

public class OrderDto
{
    public int Id { get; set; }

    public int RestaurantId { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string? Email { get; set; }

    public string? Comment { get; set; }

    public decimal TotalPrice { get; set; }

    public string Status { get; set; } = string.Empty;

    public DateTime CreatedAtUtc { get; set; }

    public List<OrderItemDto> Items { get; set; } = [];
}