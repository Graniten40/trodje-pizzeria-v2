namespace PizzeriaOrder.Api.DTOs.Menu;

public class MenuVariantDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }
}