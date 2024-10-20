using System.Text.Json.Serialization;

namespace todo_app.Domain.DTOs;

// dto used when need to read request to create todo
public class CreateTimedTodoDTO
{
    public string Name { get; set; }
    public string? Description { get; set; }
    [JsonPropertyName("due_date")]
    public DateTime DueDate { get; set; }

    public CreateTimedTodoDTO(string name, DateTime dueDate, string description = null)
    {
        Name = name;
        DueDate = dueDate;
        Description = description;
    }
}