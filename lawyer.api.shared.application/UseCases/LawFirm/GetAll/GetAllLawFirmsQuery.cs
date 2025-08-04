using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.LawFirm.GetAll;

public class GetAllLawFirmsQuery : IRequest<List<LawFirmQueryDto>>, IRequest<LawFirmQueryDto>
{
}
