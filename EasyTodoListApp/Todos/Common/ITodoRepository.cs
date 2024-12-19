
namespace EasyTodoListApp.Todos.Common;

public interface ITodoRepository
{
    Task<Todo> CreateAsync(Todo todo);
    Task DeleteAsync(Guid id);
    Task<IEnumerable<Todo>> GetAllOrEmptyAsync();
    Task<Todo?> GetByIdAsync(Guid id);
    Task<IEnumerable<Todo>> GetCompletedAsync();
    Task<IEnumerable<Todo>> GetDueTodayAsync();
    Task<IEnumerable<Todo>> GetImportantAsync();
    Task<IEnumerable<Todo>> GetOverdueAsync();
    Task ToggleCompletionAsync(Guid id);
    Task ToggleImportanceAsync(Guid id);
    Task UpdateAsync(Guid id, Todo dto);
}
