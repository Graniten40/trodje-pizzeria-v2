namespace PizzeriaOrder.Api.DTOs.Orders;

public class OrderItemExtraDto
{
    public int Id { get; set; }

    public int MenuItemExtraId { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal PriceChange { get; set; }
}