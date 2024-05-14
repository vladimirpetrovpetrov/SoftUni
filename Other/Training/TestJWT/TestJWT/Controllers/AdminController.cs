using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;
using Serilog;
using System.Security;
using TestJWT.Contracts;
using TestJWT.Dtos;

namespace TestJWT.Controllers;

[Route("[controller]")]
[ApiController]
[Authorize(Roles = "Admin")]
public class AdminController : ControllerBase
{
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IPermissionService perService;

    public AdminController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, IPermissionService perService)
    {
        _roleManager = roleManager;
        _userManager = userManager;
        this.perService = perService;
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateRole([FromBody] RoleDto roleDto)
    {
        //Check if the role already exists
        if (await _roleManager.RoleExistsAsync(roleDto.RoleName))
        {
            return BadRequest($"Role '{roleDto.RoleName}' already exists.");
        };

        //Create the role
        var role = new IdentityRole(roleDto.RoleName);
        var result = await _roleManager.CreateAsync(role);

        //If creation succeed
        if(result.Succeeded)
        {
            foreach (var permission in roleDto.Permissions)
            {
                //If the permission exists , add it to the role
                if(!await perService.PermissionExistAsync(permission))
                {
                    await perService.AddRolePermission(permission,role.Name);
                }
            }
        }

        //Log the creation
        Log.Information($"Admin created successfully the role '{role.Name}' with {string.Join(", ", roleDto.Permissions)} permissions. at {DateTime.UtcNow}");

        return Ok($"Role '{role.Name}' has been created successfully with {string.Join(", ",roleDto.Permissions)}");

    }



}
