using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.AcademicInfo.GetAll;

public class GetAllAcademicInfoQuery : IRequest<List<AcademicInfoDto>>, IRequest<AcademicInfoDto>
{
}
