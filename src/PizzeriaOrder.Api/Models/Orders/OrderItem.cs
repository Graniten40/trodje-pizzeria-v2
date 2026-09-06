namespace PizzeriaOrder.Api.Models.Orders;

public class OrderItem
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int MenuItemId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal TotalPrice { get; set; }

    public string? Comment { get; set; }

    public Order Order { get; set; } = null!;

    public ICollection<OrderItemExtra> Extras { get; set; }
        = new List<OrderItemExtra>();

    public OrderItemVariant? Variant { get; set; }
}