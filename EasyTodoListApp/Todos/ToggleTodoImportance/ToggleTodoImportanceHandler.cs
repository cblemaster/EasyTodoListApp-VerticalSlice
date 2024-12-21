
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.ToggleTodoImportance;

public class ToggleTodoImportanceHandler(ITodoRepository todoRepository)
{
    private readonly ITodoRepository _todoRepository = todoRepository;

    public async Task<ToggleTodoImportanceResponse> Handle(ToggleTodoImportanceCommand request)
    {
        Todo? todo = await _todoRepository.GetTodoByIdAsync(request.Id);
        if (todo is null)
        {
            return new ToggleTodoImportanceResponse(); // TODO: Return not found!
        }
        else
        {
            await _todoRepository.ToggleTodoImportanceAsync(request.Id);
            return new ToggleTodoImportanceResponse(); // TODO: Return success!
        }
    }
}
