using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using TestJWT.Services;

namespace TestJWT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly JwtTokenGeneratorService _jwtTokenGeneratorService;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            JwtTokenGeneratorService jwtTokenGeneratorService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenGeneratorService = jwtTokenGeneratorService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string email, string password)
        {
            var user = new IdentityUser { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return Ok(new { Token = _jwtTokenGeneratorService.GenerateToken(user) });
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(email);
                Log.Information($"User {user.Email} logged in at {DateTime.UtcNow}");
                return Ok(new { Token = await _jwtTokenGeneratorService.GenerateToken(user) });
            }
            Log.Warning($"Unsuccessfull attempt to log with {email} at {DateTime.Now}.");
            return Unauthorized();
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok("User logged out.");
        }

    }

}
