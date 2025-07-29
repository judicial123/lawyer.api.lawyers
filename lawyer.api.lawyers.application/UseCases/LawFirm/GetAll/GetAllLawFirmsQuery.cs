using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirm.GetAll;

public class GetAllLawFirmsQuery : IRequest<List<LawFirmDto>>, IRequest<LawFirmDto>
{
}
