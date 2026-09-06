namespace PizzeriaOrder.Api.Models.Orders;

public class OrderItemVariant
{
    public int Id { get; set; }

    public int OrderItemId { get; set; }

    public int MenuItemVariantId { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public OrderItem OrderItem { get; set; } = null!;
}