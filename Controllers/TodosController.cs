using Microsoft.AspNetCore.Mvc;
using todo_app.Domain.DTOs;
using todo_app.Domain.Interfaces.Service;
using todo_app.Domain.Models;
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
    
    [HttpPost("/simple-todo")]
    public async Task<IActionResult> Create([FromBody] CreateSimpleTodoDTO? simpleTodoDto)
    {
        if (simpleTodoDto == null)
            return BadRequest("Invalid data.");
        
        var newTodo = new SimpleTodo(
            simpleTodoDto.Name,
            simpleTodoDto.Priority,
            simpleTodoDto.Description,
            simpleTodoDto.Image
        );

        await _simpleTodoService.CreateAsync(newTodo);

        return Ok(newTodo);
    }
    
    [HttpPost("/timed-todo")]
    public async Task<IActionResult> Create([FromBody] CreateTimedTodoDTO? timedTodoDto)
    {
        if (timedTodoDto == null)
            return BadRequest("Invalid data.");
        
        var newTodo = new TimedTodo(
            timedTodoDto.Name,
            timedTodoDto.DueDate,
            timedTodoDto.Description
        );

        await _timedTodoService.CreateAsync(newTodo);

        return Ok(newTodo);
    }

    [HttpPut("/simple-todo/{id}")]
    public async Task<IActionResult> Update([FromBody] UpdateSimpleTodoDTO simpleTodo, string id)
    {
        await _simpleTodoService.UpdateAsync(simpleTodo, id);

        return Ok();
    }
    
    [HttpPut("/timed-todo/{id}")]
    public async Task<IActionResult> Update([FromBody] UpdateTimedTodoDTO timedTodo, string id)
    {
        await _timedTodoService.UpdateAsync(timedTodo, id);

        return Ok();
    }
    
    //TODO - commit previous changes
}