using todo_app.Domain.Models;

namespace todo_app.Domain.Interfaces.Service;

public interface ISimpleTodoService
{
    Task<IEnumerable<SimpleTodo>> GetAllAsync();
    Task<SimpleTodo> GetByIdAsync(string id);
    Task<SimpleTodo> CreateAsync(SimpleTodo todo);
    Task<SimpleTodo> UpdateAsync(SimpleTodo todo);
    Task<SimpleTodo> DeleteAsync(string id);
}