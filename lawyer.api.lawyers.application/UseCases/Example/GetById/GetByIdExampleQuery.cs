using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Example.GetById;

public class GetByIdExampleQuery : IRequest<ExampleDto>
{
    public GetByIdExampleQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
