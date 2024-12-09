using todo_app.Domain.DTOs;
using todo_app.Domain.Interfaces.Repository;
using todo_app.Domain.Interfaces.Service;
using todo_app.Domain.Models;

namespace todo_app.Services;

public class SimpleTodoService : ISimpleTodoService
{
    private readonly ISimpleTodoRepository _repository;

    public SimpleTodoService(ISimpleTodoRepository repo)
    {
        _repository = repo;
    }

    public async Task<IEnumerable<SimpleTodo>> GetAllAsync()
    {
        return await _repository.GetAll();
    }

    public async Task<SimpleTodo> GetByIdAsync(string id)
    {
        return await _repository.GetById(id);
    }

    public async Task<SimpleTodo> CreateAsync(SimpleTodo todo)
    {
        return await _repository.Create(todo);
    }

    public async Task<SimpleTodo> UpdateAsync(UpdateSimpleTodoDTO todo, string id)
    {
        var todoToBeUpdated = await GetByIdAsync(id);

        if (todoToBeUpdated == null)
        {
            throw new ArgumentNullException("todo not found.");
        }

        todoToBeUpdated.Name = todo.Name;
        todoToBeUpdated.Description = todo.Description;
        todoToBeUpdated.Priority = todo.Priority;
        todoToBeUpdated.Image = todo.Image;

        await _repository.Update(todoToBeUpdated);
        
        return todoToBeUpdated;
    }

    public async Task<SimpleTodo> DeleteAsync(string id)
    {
        var todoToBeDeleted = await GetByIdAsync(id);

        if (todoToBeDeleted == null)
        {
            throw new ArgumentNullException("todo not found");
        }

        return await _repository.Delete(todoToBeDeleted);
    }
}