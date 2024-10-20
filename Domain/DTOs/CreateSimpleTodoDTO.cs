using todo_app.Domain.Enumerations;

namespace todo_app.Domain.DTOs;

// dto used when need to read request to create todo
public class SimpleTodoDTO
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public PriorityLevel Priority { get; set; }
    public string? Image { get; set; }
    public bool IsCompleted { get; set; }

    public SimpleTodoDTO(
        string name, 
        bool isCompleted, 
        PriorityLevel priority, 
        string description = null, 
        string image = null)
    {
        Name = name;
        IsCompleted = isCompleted;
        Priority = priority;
        Description = description;
        Image = image;
    }
}