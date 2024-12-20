using EasyTodoListApp.Todos.CreateTodo;
using EasyTodoListApp.Todos.GetTodoById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EasyTodoListApp.Controllers;

[Route("[controller]")]
[ApiController]
public class TodosController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        GetTodoByIdQuery query = new(id);
        GetTodoByIdResponse todo = await _mediator.Send(query);

        return todo is null ? NotFound($"Todo with Id {id} not found.") : Ok(todo);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTodoCommand command)
    {
        if (command == null)
        {
            return BadRequest("Invalid todo details.");
        }

        CreateTodoResponse result = await _mediator.Send(command);
        return CreatedAtAction(actionName: nameof(GetByIdAsync), value: result);
    }
}
