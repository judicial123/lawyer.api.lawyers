using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.Create;

public class CreatePracticeAreaCommand : IRequest<Guid>
{
    public Guid IdCountry { get; set; }
    public string TechnicalName { get; set; } = string.Empty;
    public string CommonName { get; set; } = string.Empty;
}
