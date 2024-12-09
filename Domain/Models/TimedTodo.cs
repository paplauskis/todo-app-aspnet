using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace todo_app.Domain.Models;

public class TimedTodo : Todo
{
    
    private DateTime _dueDate;
    
    [JsonPropertyName("due_date")]
    [Column("due_date")]
    public DateTime DueDate
    {
        get => _dueDate;
        set => _dueDate = value;
    }

    public TimedTodo(string name, DateTime dueDate, string? description = null)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
        Name = name;
        Description = description;
        DueDate = dueDate;
    }
}