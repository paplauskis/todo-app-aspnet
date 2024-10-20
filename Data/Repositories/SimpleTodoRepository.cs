using Microsoft.EntityFrameworkCore;
using todo_app.Data.Context;
using todo_app.Domain.Interfaces.Repository;
using todo_app.Domain.Models;

namespace todo_app.Data.Repositories;

public class SimpleTodoRepository : ISimpleTodoRepository
{
    private readonly AppDbContext _context;

    public SimpleTodoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SimpleTodo>> GetAll()
    {
        return await _context.SimpleTodos.ToListAsync();
    }

    public async Task<SimpleTodo> GetById(string id)
    {
        return await _context.SimpleTodos
            .SingleOrDefaultAsync(x => x.Id.ToString() == id);
    }

    public async Task<SimpleTodo> Create(SimpleTodo todo)
    {
        _context.SimpleTodos.Add(todo);
        await _context.SaveChangesAsync();

        return todo;
    }

    public async Task<SimpleTodo> Update(SimpleTodo todo)
    {
        _context.SimpleTodos.Update(todo);
        await _context.SaveChangesAsync();

        return todo;
    }

    public async Task<SimpleTodo> Delete(SimpleTodo todo)
    {
        _context.SimpleTodos.Remove(todo);
        await _context.SaveChangesAsync();

        return todo;
    }
}