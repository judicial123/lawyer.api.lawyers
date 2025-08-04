using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Lawyer.GetAll;

public class GetAllLawyersQuery : IRequest<List<LawyerQueryDto>>, IRequest<LawyerQueryDto>
{
}