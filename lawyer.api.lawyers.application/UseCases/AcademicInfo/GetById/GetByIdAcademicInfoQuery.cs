using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.AcademicInfo.GetById;

public class GetByIdAcademicInfoQuery : IRequest<AcademicInfoDto>
{
    public GetByIdAcademicInfoQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
