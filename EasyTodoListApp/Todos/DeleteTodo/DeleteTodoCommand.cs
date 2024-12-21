using MediatR;

namespace EasyTodoListApp.Todos.DeleteTodo;

public record DeleteTodoCommand(Guid Id) : IRequest<DeleteTodoResponse>;
