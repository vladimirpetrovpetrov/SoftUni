namespace TestJWT.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    [HttpGet]
    [Authorize(Policy = "TestPolicy")]
    public IActionResult Get()
    {
        return Ok("This message is only visible for authorized users!");
    }
}
