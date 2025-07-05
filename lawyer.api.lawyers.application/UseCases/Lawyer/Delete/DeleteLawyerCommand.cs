using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Lawyer.Delete;

public class DeleteLawyerCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}