
using MediatR;

namespace EasyTodoListApp.Todos.GetOverdueTodos;

public record GetOverdueTodosQuery(Guid Id) : IRequest<GetOverdueTodosResponse>;
