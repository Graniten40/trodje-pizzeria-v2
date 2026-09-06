namespace PizzeriaOrder.Api.DTOs.Orders;

public class CreateOrderItemDto
{
    public int MenuItemId { get; set; }

    public int Quantity { get; set; } = 1;

    public int? MenuItemVariantId { get; set; }

    public List<int> MenuItemExtraIds { get; set; } = [];

    public string? Comment { get; set; }
}