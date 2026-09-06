namespace PizzeriaOrder.Api.Models.Orders;

public class OrderItemExtra
{
    public int Id { get; set; }

    public int OrderItemId { get; set; }

    public int MenuItemExtraId { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal PriceChange { get; set; }

    public OrderItem OrderItem { get; set; } = null!;
}