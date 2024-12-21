using MediatR;

namespace EasyTodoListApp.Todos.ToggleTodoCompletion;

public record ToggleTodoCompletionCommand(Guid Id) : IRequest<ToggleTodoCompletionResponse>;
