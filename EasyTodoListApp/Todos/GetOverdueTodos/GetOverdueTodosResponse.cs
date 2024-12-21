
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetOverdueTodos;

public record GetOverdueTodosResponse(IEnumerable<Todo> Todos);
