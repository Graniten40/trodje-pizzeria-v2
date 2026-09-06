using PizzeriaOrder.Api.DTOs.Menu;

namespace PizzeriaOrder.Api.Services.Menu;

public interface IMenuService
{
    Task<List<MenuCategoryDto>> GetMenuAsync(
        int restaurantId,
        CancellationToken cancellationToken = default);
}