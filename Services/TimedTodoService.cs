using todo_app.Domain.DTOs;
using todo_app.Domain.Interfaces.Repository;
using todo_app.Domain.Interfaces.Service;
using todo_app.Domain.Models;

namespace todo_app.Services;

public class TimedTodoService : ITimedTodoService
{
    private readonly ITimedTodoRepository _repository;

    public TimedTodoService(ITimedTodoRepository repo)
    {
        _repository = repo;
    }

    public async Task<IEnumerable<TimedTodo>> GetAllAsync()
    {
        return await _repository.GetAll();
    }

    public async Task<TimedTodo> GetByIdAsync(string id)
    {
        return await _repository.GetById(id);
    }

    public async Task<TimedTodo> CreateAsync(TimedTodo todo)
    {
        return await _repository.Create(todo);
    }

    public async Task<TimedTodo> UpdateAsync(UpdateTimedTodoDTO todo, string id)
    {
        var todoToBeUpdated = await GetByIdAsync(id);

        if (todoToBeUpdated == null)
        {
            throw new Exception("todo not found.");
        }

        todoToBeUpdated.Name = todo.Name;
        todoToBeUpdated.Description = todo.Description;

        await _repository.Update(todoToBeUpdated);
        
        return todoToBeUpdated;
    }

    public async Task<TimedTodo> DeleteAsync(string id)
    {
        var todoToBeDeleted = await GetByIdAsync(id);

        if (todoToBeDeleted == null)
        {
            throw new Exception("todo not found");
        }

        return await _repository.Delete(todoToBeDeleted);
    }
}