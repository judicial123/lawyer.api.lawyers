using MediatR;

namespace ${SolutionName}.Application.UseCases.AcademicInfo.Create;

public class CreateAcademicInfoCommand : IRequest<Guid>
{
    public Guid LawyerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

