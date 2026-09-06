namespace PizzeriaOrder.Api.DTOs.Menu;

public class MenuItemDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? ImageUrl { get; set; }

    public List<MenuVariantDto> Variants { get; set; } = [];

    public List<MenuExtraDto> Extras { get; set; } = [];
}