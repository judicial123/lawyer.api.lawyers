using lawyer.api.shared.application.Contracts.Interfaces.Persistence.LawFirm;
using MediatR;

namespace lawyer.api.shared.application.UseCases.LawFirm.Delete;

public class DeleteLawFirmCommandHandler : IRequestHandler<DeleteLawFirmCommand, Unit>
{
    private readonly ILawFirmCommandRepository _command;
    private readonly ILawFirmQueryRepository _query;

    public DeleteLawFirmCommandHandler(ILawFirmCommandRepository command, ILawFirmQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Unit> Handle(DeleteLawFirmCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        await _command.DeleteAsync(entity);
        return Unit.Value;
    }
}
