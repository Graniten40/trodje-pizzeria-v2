namespace PizzeriaOrder.Api.Models.Menu;

public class MenuCategory
{
    public int Id { get; set; }

    public int RestaurantId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int SortOrder { get; set; }

    public bool IsActive { get; set; } = true;

    public Restaurant Restaurant { get; set; } = null!;

    public ICollection<MenuItem> MenuItems { get; set; }
        = new List<MenuItem>();
}