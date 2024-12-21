
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetOverdueTodos;

public class GetOverdueTodosHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public GetOverdueTodosResponse Handle(GetOverdueTodosQuery request)
    {
        IEnumerable<Todo> todos = _todoRepository.GetOverdueTodos();

        return new GetOverdueTodosResponse(todos);
    }
}
