
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.GetTodoById;

public class GetTodoByIdHandler(ITodoRepository orderRepository)
{
    private readonly ITodoRepository _todoRepository = orderRepository;

    public async Task<GetTodoByIdResponse> Handle(GetTodoByIdQuery request)
    {
        Todo? todo = await _todoRepository.GetTodoByIdAsync(request.Id);

        return new GetTodoByIdResponse(todo ?? Todo.NotFound);
    }
}
