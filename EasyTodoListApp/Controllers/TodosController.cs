
using EasyTodoListApp.Todos.Create;
using EasyTodoListApp.Todos.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EasyTodoListApp.Controllers;

[Route("[controller]")]
[ApiController]
public class TodosController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        GetByIdQuery query = new(id);
        GetByIdResponse todo = await _mediator.Send(query);

        return todo is null ? NotFound($"Todo with Id {id} not found.") : Ok(todo);
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCommand command)
    {
        if (command == null)
        {
            return BadRequest("Invalid todo details.");
        }

        CreateResponse result = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetByIdAsync), new { Id = result.Todo.Id }, result);
    }
}
