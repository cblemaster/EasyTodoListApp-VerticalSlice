
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.UpdateTodo;

public class UpdateTodoHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public async Task<UpdateTodoResponse> Handle(UpdateTodoCommand request)
    {
        Todo? todo = await _todoRepository.GetTodoByIdAsync(request.Id);
        if (todo is null)
        {
            return new UpdateTodoResponse(); // TODO: Return not found!
        }
        else
        {
            await _todoRepository.UpdateTodoAsync(request.Id, request.Description, request.DueDate);
            return new UpdateTodoResponse(); // TODO: Return success!
        }
    }
}
