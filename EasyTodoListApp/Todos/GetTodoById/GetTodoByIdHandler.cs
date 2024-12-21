
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetTodoById;

public class GetTodoByIdHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public async Task<GetTodoByIdResponse> Handle(GetTodoByIdQuery request)
    {
        Todo? todo = await _todoRepository.GetTodoByIdAsync(request.Id);

        return new GetTodoByIdResponse(todo ?? Todo.NotFound);
    }
}
