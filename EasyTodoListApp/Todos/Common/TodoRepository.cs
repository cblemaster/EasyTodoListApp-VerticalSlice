
using Microsoft.EntityFrameworkCore;

namespace EasyTodoListApp.Todos.Common;

public class TodoRepository(DbContext context) : ITodoRepository
{
    private readonly DbContext _context = context;

    public async Task<Todo> CreateTodoAsync(Todo todo)
    {
        await _context.Set<Todo>().AddAsync(todo);
        await _context.SaveChangesAsync();
        return todo;
    }

    public async Task DeleteTodoAsync(Guid id)
    {
        if (await GetTodoByIdAsync(id) is Todo todo)
        {
            _context.Set<Todo>().Remove(todo);
            await _context.SaveChangesAsync();
        }
    }

    public IEnumerable<Todo> GetAllTodosOrEmpty() => _context.Set<Todo>().AsEnumerable();

    public IEnumerable<Todo> GetCompletedTodos() => (GetAllTodosOrEmpty()).Where(t => t.IsComplete).AsEnumerable();

    public IEnumerable<Todo> GetDueTodayTodos() =>
        (GetAllTodosOrEmpty()).Where(t => t.DueDate.HasValue && t.DueDate.Value == DateOnly.FromDateTime(DateTime.Today) && !t.IsComplete).AsEnumerable();

    public IEnumerable<Todo> GetImportantTodos() => (GetAllTodosOrEmpty()).Where(t => t.IsImportant && !t.IsComplete).AsEnumerable();

    public IEnumerable<Todo> GetOverdueTodos() =>
        (GetAllTodosOrEmpty()).Where(t => t.DueDate.HasValue && t.DueDate.Value < DateOnly.FromDateTime(DateTime.Today) && !t.IsComplete).AsEnumerable();

    public async Task ToggleTodoCompletionAsync(Guid id)
    {
        if (await GetTodoByIdAsync(id) is Todo todo)
        {
            todo.IsComplete = !todo.IsComplete;
            await _context.SaveChangesAsync();
        }
    }

    public async Task ToggleTodoImportanceAsync(Guid id)
    {
        if (await GetTodoByIdAsync(id) is Todo todo)
        {
            todo.IsImportant = !todo.IsImportant;
            await _context.SaveChangesAsync();
        }
    }

    public async Task UpdateTodoAsync(Guid id, Todo dto)
    {
        if (await GetTodoByIdAsync(id) is Todo todo)
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

    public async Task<Todo?> GetTodoByIdAsync(Guid id) => await _context.Set<Todo>().FindAsync(id);
}
