using todo_app.Domain.Models;

namespace todo_app.Utilities;

public static class TodoMapper
{
    public static IEnumerable<object> Convert<T>(IEnumerable<T> todos) where T : Todo
    {
        return todos.Select(t => (object)t);
    }
}