
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.DeleteTodo;

public class DeleteTodoHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public async Task<DeleteTodoResponse> Handle(DeleteTodoCommand request)
    {
        Todo? todo = await _todoRepository.GetTodoByIdAsync(request.Id);
        if (todo is null)
        {
            return new DeleteTodoResponse(); // TODO: Return not found!
        }
        else
        {
            await _todoRepository.DeleteTodoAsync(request.Id);
            return new DeleteTodoResponse(); // TODO: Return success!
        }
    }
}
