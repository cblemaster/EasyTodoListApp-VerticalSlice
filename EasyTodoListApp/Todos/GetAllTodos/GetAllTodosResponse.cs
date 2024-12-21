
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetAllTodos;

public record GetAllTodosResponse(IEnumerable<Todo> Todos);
