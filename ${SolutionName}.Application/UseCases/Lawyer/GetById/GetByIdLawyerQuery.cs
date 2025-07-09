using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.Lawyer.GetById;

public class GetByIdLawyerQuery : IRequest<LawyerDto>
{
    public GetByIdLawyerQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }}