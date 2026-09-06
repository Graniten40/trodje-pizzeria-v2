namespace PizzeriaOrder.Api.DTOs.Menu;

public class MenuCategoryDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int SortOrder { get; set; }

    public List<MenuItemDto> Items { get; set; } = [];
}