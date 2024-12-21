
using MediatR;

namespace EasyTodoListApp.Todos.GetDueTodayTodos;

public record GetDueTodayTodosQuery(Guid Id) : IRequest<GetDueTodayTodosResponse>;
