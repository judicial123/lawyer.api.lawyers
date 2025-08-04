using MediatR;

namespace lawyer.api.shared.application.UseCases.Lawyer.Delete;

public class DeleteLawyerCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}