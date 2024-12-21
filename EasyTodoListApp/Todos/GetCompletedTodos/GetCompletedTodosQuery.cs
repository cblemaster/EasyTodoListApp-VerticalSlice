
using MediatR;

namespace EasyTodoListApp.Todos.GetCompletedTodos;

public record GetCompletedTodosQuery(Guid Id) : IRequest<GetCompletedTodosResponse>;
