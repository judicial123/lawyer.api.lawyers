using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.AcademicInfo.GetById;

public class GetByIdAcademicInfoQuery : IRequest<AcademicInfoDto>
{
    public GetByIdAcademicInfoQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
