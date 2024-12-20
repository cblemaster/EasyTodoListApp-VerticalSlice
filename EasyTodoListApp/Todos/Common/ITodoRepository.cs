
namespace EasyTodoListApp.Todos.Common;

public interface ITodoRepository
{
    Task<Todo> CreateTodoAsync(Todo todo);
    Task DeleteTodoAsync(Guid id);
    IEnumerable<Todo> GetAllTodosOrEmpty();
    Task<Todo?> GetTodoByIdAsync(Guid id);
    IEnumerable<Todo> GetCompletedTodos();
    IEnumerable<Todo> GetDueTodayTodos();
    IEnumerable<Todo> GetImportantTodos();
    IEnumerable<Todo> GetOverdueTodos();
    Task ToggleTodoCompletionAsync(Guid id);
    Task ToggleTodoImportanceAsync(Guid id);
    Task UpdateTodoAsync(Guid id, Todo dto);
}
