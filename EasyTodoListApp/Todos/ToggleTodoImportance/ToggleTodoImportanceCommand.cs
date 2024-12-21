
using MediatR;

namespace EasyTodoListApp.Todos.ToggleTodoImportance;

public record ToggleTodoImportanceCommand(Guid Id) : IRequest<ToggleTodoImportanceResponse>;
