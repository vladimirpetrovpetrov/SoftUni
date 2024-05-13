using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TestJWT.Data;

namespace TestJWT.Services;

public class JwtTokenGeneratorService
{
    private readonly IConfiguration _configuration;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ApplicationDbContext _context;
    private readonly RoleManager<IdentityRole> _roleManager;

    public JwtTokenGeneratorService(IConfiguration configuration,
        ApplicationDbContext dbContext,
        RoleManager<IdentityRole> roleManager,
        UserManager<IdentityUser> userManager)
    {
        _configuration = configuration;
        _context = dbContext;
        _roleManager = roleManager;
        _userManager = userManager;
    }

    public async Task<string> GenerateToken(IdentityUser user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //Get the user role
        var roles = await _userManager.GetRolesAsync(user);

        var claims = new List<Claim>
    {
        new Claim(JwtRegisteredClaimNames.Sub, user.Email),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

        // Add claims for role (or roles)
        foreach (var roleName in roles)
        {
            //Adding claim for the role
            claims.Add(new Claim(ClaimTypes.Role, roleName));

            // Get the role by name
            var role = await _roleManager.FindByNameAsync(roleName);

            // Get the permissions for this role from the database
            var rolePermissions = _context.RolesPermissions
                .Include(rp=> rp.Role)
                .Include(rp=>rp.Permission)
                .Where(rp => rp.RoleId == role.Id);

            // Debugging code
            var roleNAME = role.Name;
            var countPermissions = rolePermissions.Count();


            // Add a claim for each permission
            foreach (var permission in rolePermissions)
            {
                claims.Add(new Claim("Permission", permission.Permission.Name));
            }
        }

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Issuer"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpiryInMinutes"])),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

