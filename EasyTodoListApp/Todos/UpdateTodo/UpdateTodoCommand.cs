
using EasyTodoListApp.Todos.ToggleTodoCompletion;
using MediatR;

namespace EasyTodoListApp.Todos.UpdateTodo;

public record UpdateTodoCommand(Guid Id, string Description, DateOnly? DueDate) : IRequest<ToggleTodoCompletionResponse>;
