using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.Example.GetAll;

public class GetAllExampleQuery : IRequest<List<ExampleDto>>, IRequest<ExampleDto>
{
}
