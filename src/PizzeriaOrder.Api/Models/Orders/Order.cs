namespace PizzeriaOrder.Api.Models.Orders;

public class Order
{
    public int Id { get; set; }

    public int RestaurantId { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string? Email { get; set; }

    public string? Comment { get; set; }

    public decimal TotalPrice { get; set; }

    public string Status { get; set; } = "New";

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public Restaurant Restaurant { get; set; } = null!;

    public ICollection<OrderItem> Items { get; set; }
        = new List<OrderItem>();
}