using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirm.GetById;

public class GetByIdLawFirmQuery : IRequest<LawFirmDto>
{
    public GetByIdLawFirmQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
