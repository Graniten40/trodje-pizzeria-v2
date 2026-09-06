using PizzeriaOrder.Api.Models.Menu;

namespace PizzeriaOrder.Api.Models;

public class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Address { get; set; }

    public string? PostalCode { get; set; }

    public string? City { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<MenuCategory> MenuCategories { get; set; }
        = new List<MenuCategory>();
}