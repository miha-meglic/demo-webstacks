using Microsoft.AspNetCore.Mvc;

namespace aspdotnet_tutorial.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHelloArg(String name)
    {
        if (name is null)
            name = "World";

        return Ok($"Hello, {name}!");
    }

    [HttpGet("{name}")]
    public IActionResult GetHelloPath(String name)
    {
        return Ok($"Hello, {name}!");
    }
}
