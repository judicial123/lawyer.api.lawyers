using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.AcademicInfo.GetById;

public class GetByIdAcademicInfoQuery : IRequest<AcademicInfoDto>
{
    public GetByIdAcademicInfoQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
