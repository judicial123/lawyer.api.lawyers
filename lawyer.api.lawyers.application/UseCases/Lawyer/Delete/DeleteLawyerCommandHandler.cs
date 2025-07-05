using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Lawyer.Delete;

public class DeleteLawyerCommandHandler : IRequestHandler<DeleteLawyerCommand, Unit>
{
    private readonly ILawyerCommandRepository _lawyerCommand;
    private readonly ILawyerQueryRepository _lawyerQuery;

    public DeleteLawyerCommandHandler(ILawyerCommandRepository lawyerCommand, ILawyerQueryRepository lawyerQuery)
    {
        _lawyerCommand = lawyerCommand;
        _lawyerQuery = lawyerQuery;
    }

    public async Task<Unit> Handle(DeleteLawyerCommand request, CancellationToken cancellationToken)
    {
        var lawyerToDelete = await _lawyerQuery.GetByIdAsync(request.Id);

        await _lawyerCommand.DeleteAsync(lawyerToDelete);

        return Unit.Value;
    }
}