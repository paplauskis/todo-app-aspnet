using Microsoft.EntityFrameworkCore;
using todo_app.Data.Context;
using todo_app.Domain.Interfaces.Repository;
using todo_app.Domain.Models;

namespace todo_app.Data.Repositories;

public class TimedTodoRepository : ITimedTodoRepository
{
    private readonly AppDbContext _context;

    public TimedTodoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TimedTodo>> GetAll()
    {
        return await _context.TimedTodos.ToListAsync();
    }
    
    public async Task<TimedTodo> GetById(string id)
    {
        return await _context.TimedTodos
            .SingleOrDefaultAsync(x => x.Id.ToString() == id);
    }

    public async Task<TimedTodo> Create(TimedTodo todo)
    {
        _context.TimedTodos.Add(todo);
        await _context.SaveChangesAsync();

        return todo;
    }

    public async Task<TimedTodo> Update(TimedTodo todo)
    {
        _context.TimedTodos.Update(todo);
        await _context.SaveChangesAsync();

        return todo;
    }

    public async Task<TimedTodo> Delete(TimedTodo todo)
    {
        _context.TimedTodos.Remove(todo);
        await _context.SaveChangesAsync();

        return todo;
    }
}