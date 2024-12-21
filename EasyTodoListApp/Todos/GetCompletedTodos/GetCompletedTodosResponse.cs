
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetCompletedTodos;

public record GetCompletedTodosResponse(IEnumerable<Todo> Todos);
