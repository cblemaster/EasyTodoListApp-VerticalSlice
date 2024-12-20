
using EasyTodoListApp.Todos.Common;

namespace EasyTodoListApp.Todos.Create;

public class CreateTodoHandler(ITodoRepository orderRepository)
{
    private readonly ITodoRepository _todoRepository = orderRepository;

    public async Task<CreateTodoResponse> Handle(CreateTodoCommand request)
    {
        Todo todo = new()
        {
            Id = Guid.CreateVersion7(),
            Description = request.Description,
            DueDate = request.DueDate,
            IsImportant = request.IsImportant,
            IsComplete = request.IsComplete,
            CreateDate = DateTime.Now,
        };

        await _todoRepository.CreateTodoAsync(todo);

        return new CreateTodoResponse(todo);
    }
}
