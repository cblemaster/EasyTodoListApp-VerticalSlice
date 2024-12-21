using MediatR;

namespace EasyTodoListApp.Todos.GetAllTodos;

public record GetAllTodosQuery(Guid Id) : IRequest<GetAllTodosResponse>;
