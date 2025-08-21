using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.PracticeArea.Create;
using lawyer.api.lawyers.application.UseCases.PracticeArea.Delete;
using lawyer.api.lawyers.application.UseCases.PracticeArea.GetAll;
using lawyer.api.lawyers.application.UseCases.PracticeArea.GetById;
using lawyer.api.lawyers.application.UseCases.PracticeArea.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lawyer.api.lawyers.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class PracticeAreaController : ControllerBase
{
    private readonly IMediator _mediator;

    public PracticeAreaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<PracticeAreaDto>>> Get()
    {
        var entities = await _mediator.Send(new GetAllPracticeAreaQuery());
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PracticeAreaDto>> Get(Guid id)
    {
        var entity = await _mediator.Send(new GetByIdPracticeAreaQuery(id));
        return Ok(entity);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreatePracticeAreaCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdatePracticeAreaCommand command)
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
        var command = new DeletePracticeAreaCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}
