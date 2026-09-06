namespace PizzeriaOrder.Api.Models.Menu;

public class MenuItemVariant
{
    public int Id { get; set; }

    public int MenuItemId { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int SortOrder { get; set; }

    public bool IsActive { get; set; } = true;

    public MenuItem MenuItem { get; set; } = null!;
}