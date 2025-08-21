using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.GetById;

public class GetByIdPracticeAreaQuery : IRequest<PracticeAreaDto>
{
    public GetByIdPracticeAreaQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}
