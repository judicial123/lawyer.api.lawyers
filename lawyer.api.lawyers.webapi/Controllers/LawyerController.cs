using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.Lawyer.Create;
using lawyer.api.lawyers.application.UseCases.Lawyer.Delete;
using lawyer.api.lawyers.application.UseCases.Lawyer.GetAll;
using lawyer.api.lawyers.application.UseCases.Lawyer.GetById;
using lawyer.api.lawyers.application.UseCases.Lawyer.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lawyer.api.lawyers.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class LawyerController : ControllerBase
{
    private readonly IMediator _mediator;

    public LawyerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<LawyerQueryDto>>> Get()
    {
        var lawyers = await _mediator.Send(new GetAllLawyersQuery());
        return Ok(lawyers);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LawyerQueryDto>> Get(Guid id)
    {
        var lawyer = await _mediator.Send(new GetByIdLawyerQuery(id));
        return Ok(lawyer);
    }
    
    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreateLawyerCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }
    
    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdateLawyerCommand command)
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
        var command = new DeleteLawyerCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}