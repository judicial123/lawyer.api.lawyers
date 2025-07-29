using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.LawFirm.Create;
using lawyer.api.lawyers.application.UseCases.LawFirm.Delete;
using lawyer.api.lawyers.application.UseCases.LawFirm.GetAll;
using lawyer.api.lawyers.application.UseCases.LawFirm.GetById;
using lawyer.api.lawyers.application.UseCases.LawFirm.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lawyer.api.lawyers.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class LawFirmController : ControllerBase
{
    private readonly IMediator _mediator;

    public LawFirmController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<LawFirmDto>>> Get()
    {
        var entities = await _mediator.Send(new GetAllLawFirmsQuery());
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LawFirmDto>> Get(Guid id)
    {
        var entity = await _mediator.Send(new GetByIdLawFirmQuery(id));
        return Ok(entity);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreateLawFirmCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdateLawFirmCommand command)
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
        var command = new DeleteLawFirmCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}
