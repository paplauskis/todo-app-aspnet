namespace todo_app.Domain.DTOs;

public class UpdateTimedTodoDTO
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public UpdateTimedTodoDTO(
        Guid id,
        string name,
        DateTime dueDate,
        bool isCompleted,
        string description = null)
    {
        Id = id;
        Name = name;
        DueDate = dueDate;
        IsCompleted = isCompleted;
        Description = description;
    }
}