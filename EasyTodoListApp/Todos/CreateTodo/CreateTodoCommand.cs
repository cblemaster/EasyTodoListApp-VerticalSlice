
using MediatR;

namespace EasyTodoListApp.Todos.Create;

public record CreateTodoCommand(string Description, DateOnly? DueDate, bool IsImportant, bool IsComplete) : IRequest<CreateTodoResponse>;
