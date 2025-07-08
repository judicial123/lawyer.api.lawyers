using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.AcademicInfo.GetAll;

public class GetAllAcademicInfoQuery : IRequest<List<AcademicInfoDto>>, IRequest<AcademicInfoDto>
{
}
