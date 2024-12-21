
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.ToggleTodoCompletion;

public class ToggleTodoCompletionHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public async Task<ToggleTodoCompletionResponse> Handle(ToggleTodoCompletionCommand request)
    {
        Todo? todo = await _todoRepository.GetTodoByIdAsync(request.Id);
        if (todo is null)
        {
            return new ToggleTodoCompletionResponse(); // TODO: Return not found!
        }
        else
        {
            await _todoRepository.ToggleTodoCompletionAsync(request.Id);
            return new ToggleTodoCompletionResponse(); // TODO: Return success!
        }
    }
}
