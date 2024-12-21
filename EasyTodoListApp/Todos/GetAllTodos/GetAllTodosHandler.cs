
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetAllTodos;

public class GetAllTodosHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public GetAllTodosResponse Handle(GetAllTodosQuery request)
    {
        IEnumerable<Todo> todos = _todoRepository.GetAllTodosOrEmpty();

        return new GetAllTodosResponse(todos);
    }
}
