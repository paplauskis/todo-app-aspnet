using todo_app.Domain.Enumerations;

namespace todo_app.Domain.DTOs;

public class UpdateSimpleTodoDTO
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public PriorityLevel Priority { get; set; }
    public string? Image { get; set; }
    public bool IsCompleted { get; set; }

    public UpdateSimpleTodoDTO(
        Guid id,
        string name, 
        bool isCompleted, 
        PriorityLevel priority,
        string description = null, 
        string image = null)
    { 
        Id = id;
        Name = name;
        IsCompleted = isCompleted;
        Priority = priority;
        Description = description;
        Image = image;
    }
}