namespace TestJWT.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    [HttpGet]
    [Route("read")]
    [Authorize(Policy = "ReadZone")]
    public IActionResult Read()
    {
        return Ok("This message is only visible for users with Role that has ReadZone permission!");
    }

    [HttpGet]
    [Route("create")]
    [Authorize(Policy = "CreateZone")]
    public IActionResult Create()
    {
        return Ok("This message is only visible for users with CreateZone permission installed in their Role!");
    }

    [HttpGet]
    [Route("delete")]
    [Authorize(Roles = "LevelOne")]
    public IActionResult Delete()
    {
        return Ok("This message is only visible for users with Role that has CreateZone permission!");
    }
}
