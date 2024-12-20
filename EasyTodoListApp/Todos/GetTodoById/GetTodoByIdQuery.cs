
using MediatR;

namespace EasyTodoListApp.Todos.GetTodoById;

public record GetTodoByIdQuery(Guid Id) : IRequest<GetTodoByIdResponse>;
