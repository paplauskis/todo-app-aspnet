using Microsoft.EntityFrameworkCore;
using todo_app.Models;

namespace todo_app.Data;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Todo> Todos { get; set; }
}