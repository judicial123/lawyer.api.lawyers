using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Lawyer;
using MediatR;

namespace ${SolutionName}.Application.UseCases.Lawyer.Update;

public class UpdateLawyerCommandHandler : IRequestHandler<UpdateLawyerCommand, Guid>
{
    private readonly ILawyerCommandRepository _lawyerCommand;
    private readonly ILawyerQueryRepository _lawyerQuery;

    public UpdateLawyerCommandHandler(
        ILawyerCommandRepository lawyerCommand,
        ILawyerQueryRepository lawyerQuery)
    {
        _lawyerCommand = lawyerCommand;
        _lawyerQuery = lawyerQuery;
    }

    public async Task<Guid> Handle(UpdateLawyerCommand request, CancellationToken cancellationToken)
    {
        var existingLawyer = await _lawyerQuery.GetByIdAsync(request.Id);
        if (existingLawyer == null) throw new KeyNotFoundException($"The lawyer with ID {request.Id} does not exist.");

        existingLawyer.City = request.City;
        existingLawyer.Name = request.Name;
        existingLawyer.Title = request.Title;
        existingLawyer.CredentialNumber = request.CredentialNumber;
        existingLawyer.Phone = request.Phone;
        existingLawyer.Address = request.Address;
        existingLawyer.GoogleMapsAddress = request.GoogleMapsAddress;
        existingLawyer.SocialMediaLinks = request.SocialMediaLinks;
        existingLawyer.DateModified = DateTime.UtcNow;

        await _lawyerCommand.UpdateAsync(existingLawyer);

        return existingLawyer.Id;
    }
}