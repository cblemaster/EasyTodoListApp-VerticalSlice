
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetImportantTodos;

public class GetImportantTodosHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public GetImportantTodosResponse Handle(GetImportantTodosQuery request)
    {
        IEnumerable<Todo> todos = _todoRepository.GetImportantTodos();

        return new GetImportantTodosResponse(todos);
    }
}
