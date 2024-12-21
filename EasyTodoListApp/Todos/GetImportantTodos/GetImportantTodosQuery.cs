
using MediatR;

namespace EasyTodoListApp.Todos.GetImportantTodos;

public record GetImportantTodosQuery(Guid Id) : IRequest<GetImportantTodosResponse>;
