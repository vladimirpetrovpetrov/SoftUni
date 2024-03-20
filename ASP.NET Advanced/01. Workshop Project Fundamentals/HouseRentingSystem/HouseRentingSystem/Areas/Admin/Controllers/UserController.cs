using HouseRentingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Areas.Admin.Controllers;

public class UserController : AdminController
{
    private readonly IApplicationUserService userService;

    public UserController(IApplicationUserService userService)
    {
        this.userService = userService;
    }
    [Route("User/All")]
    public async Task<IActionResult> All()
    {
        var users =  await userService.All();
        return View(users);
    }
}
