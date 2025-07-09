using MediatR;

namespace ${SolutionName}.Application.UseCases.Lawyer.Delete;

public class DeleteLawyerCommand : IRequest<Unit>
{
    public Guid Id { get; set; }}