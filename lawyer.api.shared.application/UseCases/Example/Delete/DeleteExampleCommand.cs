using MediatR;

namespace lawyer.api.shared.application.UseCases.Example.Delete;

public class DeleteExampleCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
