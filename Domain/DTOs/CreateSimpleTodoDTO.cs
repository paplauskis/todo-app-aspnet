using todo_app.Domain.Enumerations;

namespace todo_app.Domain.DTOs;

// dto used when need to read request to create todo
public class CreateSimpleTodoDTO
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public PriorityLevel Priority { get; set; }
    public string? Image { get; set; }

    public CreateSimpleTodoDTO(
        string name, 
        PriorityLevel priority, 
        string description = null, 
        string image = null)
    {
        Name = name;
        Priority = priority;
        Description = description;
        Image = image;
    }
}