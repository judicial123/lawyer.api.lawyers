using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Example.GetAll;

public class GetAllExampleQuery : IRequest<List<ExampleDto>>, IRequest<ExampleDto>
{
}
