using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Example.Create;

public class CreateExampleCommand : IRequest<Guid>
{
    public string PropertyOne { get; set; } = string.Empty;
    public string PropertyTwo { get; set; } = string.Empty;
}
