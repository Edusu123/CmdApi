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

    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandItem(int id)
    {
        var commandItem = _context.CommandItems.Find(id);

        if (commandItem == null)
        {
            return NotFound();
        }

        return commandItem;
    }
}
