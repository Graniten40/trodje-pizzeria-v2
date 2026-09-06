namespace PizzeriaOrder.Api.Models.Menu;

public class MenuItem
{
    public int Id { get; set; }

    public int MenuCategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? ImageUrl { get; set; }

    public int SortOrder { get; set; }

    public bool IsActive { get; set; } = true;

    public MenuCategory MenuCategory { get; set; } = null!;

    public ICollection<MenuItemVariant> Variants { get; set; }
        = new List<MenuItemVariant>();

    public ICollection<MenuItemExtra> Extras { get; set; }
        = new List<MenuItemExtra>();
}