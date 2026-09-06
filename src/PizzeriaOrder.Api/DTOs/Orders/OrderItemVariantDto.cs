namespace PizzeriaOrder.Api.DTOs.Orders;

public class OrderItemVariantDto
{
    public int Id { get; set; }

    public int MenuItemVariantId { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }
}