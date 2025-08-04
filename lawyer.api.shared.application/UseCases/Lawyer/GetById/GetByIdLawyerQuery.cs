using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Lawyer.GetById;

public class GetByIdLawyerQuery : IRequest<LawyerQueryDto>
{
    public GetByIdLawyerQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}