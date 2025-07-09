using MediatR;

namespace ${SolutionName}.Application.UseCases.AcademicInfo.Delete;

public class DeleteAcademicInfoCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
