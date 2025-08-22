using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.GetAll;

public class GetAllLawFirmPracticeAreaQuery : IRequest<List<LawFirmPracticeAreaDto>>
{
}

