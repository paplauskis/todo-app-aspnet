namespace todo_app.Domain.DTOs;

public class TimedTodoDTO
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime DueDate { get; set; }

    public TimedTodoDTO(string name, bool isCompleted, DateTime dueDate, string description = null)
    {
        Name = name;
        IsCompleted = isCompleted;
        DueDate = dueDate;
        Description = description;
    }
}