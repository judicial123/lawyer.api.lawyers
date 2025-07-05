using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Lawyer.GetAll;

public class GetAllLawyersQuery : IRequest<List<LawyerDto>>, IRequest<LawyerDto>
{
}