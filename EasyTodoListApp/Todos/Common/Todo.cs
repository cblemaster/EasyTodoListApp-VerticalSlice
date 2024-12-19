
namespace EasyTodoListApp.Todos.Common;

public class Todo
{
    public string Description { get; set; } = string.Empty;
    public DateOnly? DueDate { get; set; }
    public bool IsImportant { get; set; }
    public bool IsComplete { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public Guid Id { get; set; }
}

// TODO: Create separate domain and persistence models
