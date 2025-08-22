using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.Delete;

public class DeletePracticeAreaCommand : IRequest
{
    public Guid Id { get; set; }
}
