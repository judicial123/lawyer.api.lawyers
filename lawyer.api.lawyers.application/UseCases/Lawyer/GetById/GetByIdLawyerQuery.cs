using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Lawyer.GetById;

public class GetByIdLawyerQuery : IRequest<LawFirmQueryDto>
{
    public GetByIdLawyerQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}