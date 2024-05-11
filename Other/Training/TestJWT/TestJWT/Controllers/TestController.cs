namespace TestJWT.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    
    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        return Ok("Това съобщение е видимо само за авторизирани потребители.");
    }
}
