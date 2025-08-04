using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.AcademicInfo.GetAll;

public class GetAllAcademicInfoQuery : IRequest<List<AcademicInfoDto>>, IRequest<AcademicInfoDto>
{
}
