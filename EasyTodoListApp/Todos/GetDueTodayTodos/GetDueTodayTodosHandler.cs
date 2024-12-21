
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetDueTodayTodos;

public class GetDueTodayTodosHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public GetDueTodayTodosResponse Handle(GetDueTodayTodosQuery request)
    {
        IEnumerable<Todo> todos = _todoRepository.GetDueTodayTodos();

        return new GetDueTodayTodosResponse(todos);
    }
}
