using todo_app.Domain.DTOs;
using todo_app.Domain.Models;

namespace todo_app.Domain.Interfaces.Service;

public interface ITimedTodoService
{
    Task<IEnumerable<TimedTodo>> GetAllAsync();
    Task<TimedTodo> GetByIdAsync(string id);
    Task<TimedTodo> CreateAsync(TimedTodo todo);
    Task<TimedTodo> UpdateAsync(UpdateTimedTodoDTO todo, string id);
    Task<TimedTodo> DeleteAsync(string id);
}