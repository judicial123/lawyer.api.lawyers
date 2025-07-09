using MediatR;

namespace ${SolutionName}.Application.UseCases.Example.Update;

public class UpdateExampleCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string PropertyOne { get; set; } = string.Empty;
    public string PropertyTwo { get; set; } = string.Empty;
}
