
using EasyTodoListApp.Todos.Common;
using MediatR;

namespace EasyTodoListApp.Todos.GetById;

public class GetByIdHandler(ITodoRepository orderRepository)
{
	private readonly ITodoRepository _todoRepository = orderRepository;

	public async Task<GetByIdResponse> Handle(GetByIdQuery request)
	{
		Todo? todo = await _todoRepository.GetByIdAsync(request.Id);

		return new GetByIdResponse(todo ?? Todo.NotFound);
	}
}
