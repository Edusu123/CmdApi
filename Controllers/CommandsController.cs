using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CommandsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> GetString()
    {
        return new string[] { "this", "is", "easy" };
    }
}
