using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Serilog;
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
    [Route("createRole")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        if (result.Succeeded)
        {
            foreach (var permission in roleDto.Permissions)
            {
                //If the permission exists , add it to the role
                if (await perService.PermissionExistAsync(permission))
                {
                    await perService.AddRolePermission(permission, role.Name);
                }
            }
        }

        //Log the creation
        Log.Information($"Admin created successfully the role '{role.Name}' with {string.Join(", ", roleDto.Permissions)} permissions. at {DateTime.UtcNow}");

        return Ok($"Role '{role.Name}' has been created successfully with {string.Join(", ", roleDto.Permissions)}");

    }

    [HttpGet]
    [Route("permissions/{roleId}")]
    [ProducesResponseType(typeof(Dictionary<string, bool>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetRolePermissions(string roleId)
    {

        var role = await _roleManager.FindByIdAsync(roleId);

        if (role == null)
        {
            return NotFound($"Role with ID '{roleId}' does not exist.");
        }


        var rolePermissions = await perService.GetAllPermissionsForRoleAsync(roleId);


        return Ok(rolePermissions);
    }

    // Create a new user
    [HttpPost]
    [Route("createUser")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateUser([FromBody] UserDto userDto)
    {
        // Check if the user already exists 
        var existingUser = await _userManager.FindByNameAsync(userDto.Email);
        if (existingUser != null)
        {
            return BadRequest($"User '{userDto.Email}' already exists.");
        }

        //Creating new user
        var user = new IdentityUser { UserName = userDto.Email, Email = userDto.Email };

        var result = await _userManager.CreateAsync(user, userDto.Password);

        if (result.Succeeded)
        {
            Log.Warning($"Admin created new user - {user.Email}");
            return Ok($"User '{userDto.Email}' has been created successfully.");
        }
        else
        {
            return BadRequest(result.Errors);
        }
    }

    // Get a user by ID
    [HttpGet]
    [Route("readUser/{userId}")]
    [ProducesResponseType(typeof(UserDataDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUser(string userId)
    {
        // Find the user by his id
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            //If user does not exist
            return NotFound($"User with ID '{userId}' does not exist.");
        }

        // Get the roles for the user
        var roles = await _userManager.GetRolesAsync(user);

        var userData = new UserDataDto
        {
            Email = user.Email,
        };

        // If the user has a role, get the permissions
        if (roles.Any())
        {
            userData.Role = roles.First();
            var role = await _roleManager.FindByNameAsync(userData.Role);
            var rolePermissions = await perService.GetAllPermissionsForRoleAsync(role.Id);
            userData.Permissions = rolePermissions;
        }

        Log.Warning($"Admin requested information about user with Id - {userId}");

        return Ok(userData);
    }
}
