using MediatR;

namespace lawyer.api.shared.application.UseCases.LawFirm.Delete;

public class DeleteLawFirmCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
