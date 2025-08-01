using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirm.GetAllBasic;

public class GetAllBasicLawFirmsQuery  : IRequest<List<LawFirmDto>>, IRequest<LawFirmDto>
{
}