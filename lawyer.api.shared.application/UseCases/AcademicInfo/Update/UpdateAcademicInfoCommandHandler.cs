using lawyer.api.shared.application.Contracts.Interfaces.Persistence.AcademicInfo;
using MediatR;

namespace lawyer.api.shared.application.UseCases.AcademicInfo.Update;

public class UpdateAcademicInfoCommandHandler : IRequestHandler<UpdateAcademicInfoCommand, Guid>
{
    private readonly IAcademicInfoCommandRepository _infoCommand;
    private readonly IAcademicInfoQueryRepository _infoQuery;

    public UpdateAcademicInfoCommandHandler(
        IAcademicInfoCommandRepository infoCommand,
        IAcademicInfoQueryRepository infoQuery)
    {
        _infoCommand = infoCommand;
        _infoQuery = infoQuery;
    }

    public async Task<Guid> Handle(UpdateAcademicInfoCommand request, CancellationToken cancellationToken)
    {
        var existingInfo = await _infoQuery.GetByIdAsync(request.Id);
        if (existingInfo == null) throw new KeyNotFoundException($"The academic info with ID {request.Id} does not exist.");

        existingInfo.LawyerId = request.LawyerId;
        existingInfo.Name = request.Name;
        existingInfo.Url = request.Url;
        existingInfo.DateModified = DateTime.UtcNow;

        await _infoCommand.UpdateAsync(existingInfo);

        return existingInfo.Id;
    }
}
