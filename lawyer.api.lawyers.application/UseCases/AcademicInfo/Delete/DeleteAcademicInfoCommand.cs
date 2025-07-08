using MediatR;

namespace lawyer.api.lawyers.application.UseCases.AcademicInfo.Delete;

public class DeleteAcademicInfoCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
