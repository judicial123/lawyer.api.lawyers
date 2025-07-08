using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Example.GetAll;

public class GetAllExampleQuery : IRequest<List<ExampleDto>>, IRequest<ExampleDto>
{
}
