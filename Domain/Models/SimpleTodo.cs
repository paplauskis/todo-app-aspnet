using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using todo_app.Domain.Enumerations;

namespace todo_app.Domain.Models;

public class SimpleTodo : Todo
{
    [JsonPropertyName("priority")]
    [Column("priority")]
    public PriorityLevel Priority { get; set; }
    
    [JsonPropertyName("image")]
    [Column("image")]
    public string? Image { get; set; }
    
    public SimpleTodo(string name, PriorityLevel priority, string? description = null, string? image = null)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
        Name = name;
        Description = description;
        Priority = priority;
        Image = image;
    }
    
}