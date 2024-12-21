
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetCompletedTodos;

public class GetCompletedTodosHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public GetCompletedTodosResponse Handle(GetCompletedTodosQuery request)
    {
        IEnumerable<Todo> todos = _todoRepository.GetCompletedTodos();

        return new GetCompletedTodosResponse(todos);
    }
}
