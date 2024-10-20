using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace todo_app.Domain.Models;

public abstract class Todo
{
    [JsonPropertyName("id")]
    [Column("id")]
    public Guid Id { get; protected init; }

    private string? _name;
    
    [JsonPropertyName("name")]
    [Column("name")]
    [MaxLength(100)]
    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentNullException(nameof(Name))
            : value;
    }
    
    [JsonPropertyName("description")]
    [Column("description")]
    [MaxLength(500)]
    public string? Description { get; set; }
    
    [JsonPropertyName("created_at")]
    [Column("created_at")]
    public DateTime CreatedAt { get; protected init; }

    [JsonPropertyName("is_completed")]
    [Column("is_completed")]
    public bool IsCompleted { get; set; }
}