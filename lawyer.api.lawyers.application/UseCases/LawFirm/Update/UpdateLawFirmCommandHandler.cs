using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirm;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirm.Update;

public class UpdateLawFirmCommandHandler : IRequestHandler<UpdateLawFirmCommand, Guid>
{
    private readonly ILawFirmCommandRepository _command;
    private readonly ILawFirmQueryRepository _query;

    public UpdateLawFirmCommandHandler(
        ILawFirmCommandRepository command,
        ILawFirmQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Guid> Handle(UpdateLawFirmCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity == null) throw new KeyNotFoundException($"The law firm with ID {request.Id} does not exist.");

        entity.IdCity = request.IdCity;
        entity.Name = request.Name;
        entity.Phone = request.Phone;
        entity.Email = request.Email;
        entity.EntryDate = request.EntryDate;
        entity.Active = request.Active;
        entity.Address = request.Address;
        entity.GoogleMapsAddress = request.GoogleMapsAddress;
        entity.Biography = request.Biography;
        entity.SocialMediaLinks = request.SocialMediaLinks;
        entity.DateModified = DateTime.UtcNow;

        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}
