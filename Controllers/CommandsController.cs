using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CommandsController : ControllerBase
{
    private readonly CommandContext _context;

    public CommandsController(CommandContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetCommandItems()
    {
        return _context.CommandItems;
    }

    // [HttpGet]
    // public ActionResult<IEnumerable<string>> GetString()
    // {
    //     return new string[] { "this", "is", "easy" };
    // }
}
