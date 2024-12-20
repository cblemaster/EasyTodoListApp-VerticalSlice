
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EasyTodoListApp.Controllers;

[Route("[controller]")]
[ApiController]
public class TodosController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    //[HttpGet("{id:guid}")]
    //public async Task<IActionResult> GetByIdAsync(Guid id)
    //{
    //    var query = new GetProductQuery(id);
    //    var product = await _mediator.Send(query);

    //    if (product == null)
    //    {
    //        return NotFound($"Product with ID {id} not found.");
    //    }

    //    return Ok(product);
    //}


    //[HttpPost]
    //public async Task<IActionResult> AddProduct([FromBody] AddProductCommand command)
    //{
    //    if (command == null)
    //    {
    //        return BadRequest("Invalid product details.");
    //    }

    //    var result = await _mediator.Send(command);
    //    return CreatedAtAction(nameof(GetProductById), new { id = result.ProductId }, result);
    //}
}
