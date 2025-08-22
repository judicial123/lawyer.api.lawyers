using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.Delete;

public class DeleteLawFirmPracticeAreaCommand : IRequest
{
    public Guid Id { get; set; }
}

