using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.Create;

public class CreateLawFirmPracticeAreaCommand : IRequest<Guid>
{
    public Guid IdLawFirm { get; set; }
    public Guid IdPracticeArea { get; set; }
}

