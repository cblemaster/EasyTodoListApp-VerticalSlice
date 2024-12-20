
using MediatR;

namespace EasyTodoListApp.Todos.GetById;

public record GetByIdQuery(Guid Id) : IRequest<GetByIdResponse>;
