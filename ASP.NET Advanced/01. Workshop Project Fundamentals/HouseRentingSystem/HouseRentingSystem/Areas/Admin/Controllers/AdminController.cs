using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static HouseRentingSystem.Areas.Admin.AdminConstants;

namespace HouseRentingSystem.Areas.Admin.Controllers;

[Area(AreaName)]
[Authorize(Roles = AdminRoleName)]
public class AdminController : Controller
{
}
