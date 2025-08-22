using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.GetById;

public class GetByIdLawFirmPracticeAreaQuery : IRequest<LawFirmPracticeAreaDto>
{
    public GetByIdLawFirmPracticeAreaQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
}

