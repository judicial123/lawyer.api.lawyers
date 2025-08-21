using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.Update;

public class UpdateLawFirmPracticeAreaCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Guid IdLawFirm { get; set; }
    public Guid IdPracticeArea { get; set; }
}

