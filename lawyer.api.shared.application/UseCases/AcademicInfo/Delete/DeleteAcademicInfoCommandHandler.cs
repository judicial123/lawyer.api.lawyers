using lawyer.api.shared.application.Contracts.Interfaces.Persistence.AcademicInfo;
using MediatR;

namespace lawyer.api.shared.application.UseCases.AcademicInfo.Delete;

public class DeleteAcademicInfoCommandHandler : IRequestHandler<DeleteAcademicInfoCommand, Unit>
{
    private readonly IAcademicInfoCommandRepository _infoCommand;
    private readonly IAcademicInfoQueryRepository _infoQuery;

    public DeleteAcademicInfoCommandHandler(IAcademicInfoCommandRepository infoCommand, IAcademicInfoQueryRepository infoQuery)
    {
        _infoCommand = infoCommand;
        _infoQuery = infoQuery;
    }

    public async Task<Unit> Handle(DeleteAcademicInfoCommand request, CancellationToken cancellationToken)
    {
        var infoToDelete = await _infoQuery.GetByIdAsync(request.Id);

        await _infoCommand.DeleteAsync(infoToDelete);

        return Unit.Value;
    }
}
