using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.LawFirm.GetAllBasic;

public class GetAllBasicLawFirmsQuery  : IRequest<List<LawFirmDto>>, IRequest<LawFirmDto>
{
}