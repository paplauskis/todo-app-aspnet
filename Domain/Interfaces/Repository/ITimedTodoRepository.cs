using todo_app.Domain.Models;

namespace todo_app.Domain.Interfaces.Repository;

public interface ITimedTodoRepository
{
    Task<IEnumerable<TimedTodo>> GetAll();
    Task<TimedTodo> GetById(string id);
    Task<TimedTodo> Create(TimedTodo todo);
    Task<TimedTodo> Update(TimedTodo todo);
    Task<TimedTodo> Delete(TimedTodo todo);
}