using Microsoft.EntityFrameworkCore;
using todo_app.Domain.Models;

namespace todo_app.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<SimpleTodo> SimpleTodos { get; set; }
    public DbSet<TimedTodo> TimedTodos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<SimpleTodo>()
            .ToTable("simple_todo")
            .HasKey(s => s.Id);
        
        modelBuilder.Entity<TimedTodo>()
            .ToTable("timed_todo")
            .HasKey(t => t.Id);
    }
    
}