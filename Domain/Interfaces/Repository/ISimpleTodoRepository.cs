using todo_app.Domain.Models;

namespace todo_app.Domain.Interfaces.Repository;

public interface ISimpleTodoRepository
{
    Task<IEnumerable<SimpleTodo>> GetAll();
    Task<SimpleTodo> GetById(string id);
    Task<SimpleTodo> Create(SimpleTodo todo);
    Task<SimpleTodo> Update(SimpleTodo todo);
    Task<SimpleTodo> Delete(SimpleTodo todo);
}