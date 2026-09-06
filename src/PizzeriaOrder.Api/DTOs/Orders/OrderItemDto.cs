namespace PizzeriaOrder.Api.DTOs.Orders;

public class OrderItemDto
{
    public int Id { get; set; }

    public int MenuItemId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal TotalPrice { get; set; }

    public string? Comment { get; set; }

    public OrderItemVariantDto? Variant { get; set; }

    public List<OrderItemExtraDto> Extras { get; set; } = [];
}