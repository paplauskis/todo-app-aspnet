using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace todo_app.Domain.Models;

public abstract class Todo
{
    [JsonPropertyName("id")]
    [Column("id")]
    public Guid Id { get; init; }

    private string? _name;
    
    [JsonPropertyName("name")]
    [Column("name")]
    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentNullException(nameof(Name))
            : value;
    }
    
    [JsonPropertyName("description")]
    [Column("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("created_at")]
    [Column("created_at")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("is_completed")]
    [Column("is_completed")]
    public bool IsCompleted { get; private set; }

    public void MarkComplete()
    {
        IsCompleted = true;
    }
    
}