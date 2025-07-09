using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.Lawyer.GetAll;

public class GetAllLawyersQuery : IRequest<List<LawyerDto>>, IRequest<LawyerDto>
{
}