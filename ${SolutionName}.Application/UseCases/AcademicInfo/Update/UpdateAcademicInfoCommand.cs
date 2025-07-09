using MediatR;

namespace ${SolutionName}.Application.UseCases.AcademicInfo.Update;

public class UpdateAcademicInfoCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Guid LawyerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
