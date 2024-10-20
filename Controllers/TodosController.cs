using Microsoft.AspNetCore.Mvc;
using todo_app.Domain.Interfaces.Service;
using todo_app.Utilities;

namespace todo_app.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class TodosController : ControllerBase
{
    //later: implement one service, repository for both timed and simple by using generic type
    private readonly ISimpleTodoService _simpleTodoService;
    private readonly ITimedTodoService _timedTodoService;

    public TodosController(ISimpleTodoService simpleTodoService, ITimedTodoService timedTodoService)
    {
        _simpleTodoService = simpleTodoService;
        _timedTodoService = timedTodoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTodos()
    {
        var simpleTodos = await _simpleTodoService.GetAllAsync();
        var timedTodos = await _timedTodoService.GetAllAsync();
        var todos1 = TodoMapper.Convert(simpleTodos);
        var todos2 = TodoMapper.Convert(timedTodos);

        return Ok(todos1.Concat(todos2));
    }
}