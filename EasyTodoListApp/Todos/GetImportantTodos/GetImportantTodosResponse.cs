using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetImportantTodos;

public record GetImportantTodosResponse(IEnumerable<Todo> Todos);
