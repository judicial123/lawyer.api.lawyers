using MediatR;

namespace ${SolutionName}.Application.UseCases.Example.Delete;

public class DeleteExampleCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
