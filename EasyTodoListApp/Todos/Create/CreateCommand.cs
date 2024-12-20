
using MediatR;

namespace EasyTodoListApp.Todos.Create;

public record CreateCommand(string Description, DateOnly? DueDate, bool IsImportant, bool IsComplete) : IRequest<CreateResponse>;
