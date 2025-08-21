using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.GetAll;

public class GetAllPracticeAreaQuery : IRequest<List<PracticeAreaDto>>
{
}
