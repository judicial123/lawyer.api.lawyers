using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.Comment.Create;
using lawyer.api.lawyers.application.UseCases.Comment.Delete;
using lawyer.api.lawyers.application.UseCases.Comment.GetAll;
using lawyer.api.lawyers.application.UseCases.Comment.GetById;
using lawyer.api.lawyers.application.UseCases.Comment.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lawyer.api.lawyers.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class CommentController : ControllerBase
{
    private readonly IMediator _mediator;

    public CommentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<CommentDto>>> Get()
    {
        var entities = await _mediator.Send(new GetAllCommentQuery());
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CommentDto>> Get(Guid id)
    {
        var entity = await _mediator.Send(new GetByIdCommentQuery(id));
        return Ok(entity);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreateCommentCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdateCommentCommand command)
    {
        if (command.Id == Guid.Empty)
            return BadRequest("The provided ID is not valid.");

        var updatedId = await _mediator.Send(command);
        return Ok(updatedId);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<ActionResult> Delete(Guid id)
    {
        var command = new DeleteCommentCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}
