using MediatR;

namespace lawyer.api.lawyers.application.UseCases.AcademicInfo.Update;

public class UpdateAcademicInfoCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public Guid LawyerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
