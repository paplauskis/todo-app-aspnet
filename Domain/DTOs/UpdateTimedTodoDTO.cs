namespace todo_app.Domain.DTOs;

public class UpdateTimedTodoDTO
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public UpdateTimedTodoDTO(
        string name,
        DateTime dueDate,
        bool isCompleted,
        string description)
    {
        Name = name;
        DueDate = dueDate;
        IsCompleted = isCompleted;
        Description = description;
    }
}