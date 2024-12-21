using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetDueTodayTodos;

public record GetDueTodayTodosResponse(IEnumerable<Todo> Todos);
