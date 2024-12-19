
using Microsoft.EntityFrameworkCore;

namespace EasyTodoListApp.Todos.Common;

public class TodoRepository(DbContext context) : ITodoRepository
{
    private readonly DbContext _context = context;

    public async Task<Todo> CreateAsync(Todo todo)
    {
        await _context.Set<Todo>().AddAsync(todo);
        await _context.SaveChangesAsync();
        return todo;
    }

    public async Task DeleteAsync(Guid id)
    {
        if (await GetByIdAsync(id) is Todo todo)
        {
            _context.Set<Todo>().Remove(todo);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Todo>> GetAllOrEmptyAsync()
    {
        IEnumerable<Todo> todos = [];
        await Task.Run(() => todos = _context.Set<Todo>().AsEnumerable());
        return todos;
    }

    public async Task<IEnumerable<Todo>> GetCompletedAsync() => (await GetAllOrEmptyAsync()).Where(t => t.IsComplete).AsEnumerable();

    public async Task<IEnumerable<Todo>> GetDueTodayAsync() =>
        (await GetAllOrEmptyAsync()).Where(t => t.DueDate.HasValue && t.DueDate.Value == DateOnly.FromDateTime(DateTime.Today) && !t.IsComplete).AsEnumerable();

    public async Task<IEnumerable<Todo>> GetImportantAsync() => (await GetAllOrEmptyAsync()).Where(t => t.IsImportant && !t.IsComplete).AsEnumerable();

    public async Task<IEnumerable<Todo>> GetOverdueAsync() =>
        (await GetAllOrEmptyAsync()).Where(t => t.DueDate.HasValue && t.DueDate.Value < DateOnly.FromDateTime(DateTime.Today) && !t.IsComplete).AsEnumerable();

    public async Task ToggleCompletionAsync(Guid id)
    {
        if (await GetByIdAsync(id) is Todo todo)
        {
            todo.IsComplete = !todo.IsComplete;
            await _context.SaveChangesAsync();
        }
    }

    public async Task ToggleImportanceAsync(Guid id)
    {
        if (await GetByIdAsync(id) is Todo todo)
        {
            todo.IsImportant = !todo.IsImportant;
            await _context.SaveChangesAsync();
        }
    }

    public async Task UpdateAsync(Guid id, Todo dto)
    {
        if (await GetByIdAsync(id) is Todo todo)
        {
            if (todo.Description != dto.Description)
            {
                todo.Description = dto.Description;
            }
            if (todo.DueDate != dto.DueDate)
            {
                todo.DueDate = dto.DueDate;
            }
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Todo?> GetByIdAsync(Guid id) => await _context.Set<Todo>().FindAsync(id);
}
