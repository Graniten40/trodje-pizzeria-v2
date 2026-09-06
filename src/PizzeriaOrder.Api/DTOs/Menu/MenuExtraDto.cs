namespace PizzeriaOrder.Api.DTOs.Menu;

public class MenuExtraDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal PriceChange { get; set; }
}