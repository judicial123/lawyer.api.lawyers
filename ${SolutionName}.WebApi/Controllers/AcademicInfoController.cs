using ${SolutionName}.Application.DTO;
using ${SolutionName}.Application.UseCases.AcademicInfo.Create;
using ${SolutionName}.Application.UseCases.AcademicInfo.Delete;
using ${SolutionName}.Application.UseCases.AcademicInfo.GetAll;
using ${SolutionName}.Application.UseCases.AcademicInfo.GetById;
using ${SolutionName}.Application.UseCases.AcademicInfo.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ${SolutionName}.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class AcademicInfoController : ControllerBase
{
    private readonly IMediator _mediator;

    public AcademicInfoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<AcademicInfoDto>>> Get()
    {
        var infos = await _mediator.Send(new GetAllAcademicInfoQuery());
        return Ok(infos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AcademicInfoDto>> Get(Guid id)
    {
        var info = await _mediator.Send(new GetByIdAcademicInfoQuery(id));
        return Ok(info);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreateAcademicInfoCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdateAcademicInfoCommand command)
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
        var command = new DeleteAcademicInfoCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}

