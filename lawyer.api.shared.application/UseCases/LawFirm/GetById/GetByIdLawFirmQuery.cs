using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.LawFirm.GetById;

public class GetByIdLawFirmQuery : IRequest<LawFirmQueryDto>
{
    public GetByIdLawFirmQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
