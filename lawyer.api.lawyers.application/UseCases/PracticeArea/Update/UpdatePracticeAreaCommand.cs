using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.Update;

public class UpdatePracticeAreaCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Guid IdCountry { get; set; }
    public string TechnicalName { get; set; } = string.Empty;
    public string CommonName { get; set; } = string.Empty;
}
