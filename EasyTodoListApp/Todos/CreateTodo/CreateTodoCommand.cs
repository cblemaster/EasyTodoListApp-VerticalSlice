
using MediatR;

namespace EasyTodoListApp.Todos.CreateTodo;

public record CreateTodoCommand(string Description, DateOnly? DueDate, bool IsImportant, bool IsComplete) : IRequest<CreateTodoResponse>;
