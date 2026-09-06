using Microsoft.AspNetCore.Mvc;
using PizzeriaOrder.Api.Services.Menu;

namespace PizzeriaOrder.Api.Controllers;

[ApiController]
[Route("api/restaurants/{restaurantId:int}/menu")]
public class MenuController : ControllerBase
{
    private readonly IMenuService _menuService;

    public MenuController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    [HttpGet]
    public async Task<IActionResult> GetMenu(
        int restaurantId,
        CancellationToken cancellationToken)
    {
        var menu = await _menuService.GetMenuAsync(
            restaurantId,
            cancellationToken);

        return Ok(menu);
    }
}