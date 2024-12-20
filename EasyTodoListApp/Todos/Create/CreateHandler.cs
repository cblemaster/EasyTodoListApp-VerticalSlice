
using EasyTodoListApp.Todos.Common;
using MediatR;

namespace EasyTodoListApp.Todos.Create;

public class CreateHandler(ITodoRepository orderRepository)
{
	private readonly ITodoRepository _todoRepository = orderRepository;

    public async Task<CreateResponse> Handle(CreateCommand request)
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

		await _todoRepository.CreateAsync(todo);

		return new CreateResponse(todo);
	}
}
