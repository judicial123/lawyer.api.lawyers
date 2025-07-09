using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.Example.GetById;

public class GetByIdExampleQuery : IRequest<ExampleDto>
{
    public GetByIdExampleQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
