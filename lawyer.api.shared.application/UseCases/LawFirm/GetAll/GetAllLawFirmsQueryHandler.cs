using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.LawFirm;
using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.LawFirm.GetAll;

public class GetAllLawFirmsQueryHandler : IRequestHandler<GetAllLawFirmsQuery, List<LawFirmQueryDto>>
{
    private readonly ILawFirmQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllLawFirmsQueryHandler(
        IMapper mapper,
        ILawFirmQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<LawFirmQueryDto>> Handle(GetAllLawFirmsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync("Lawyers");
        return _mapper.Map<List<LawFirmQueryDto>>(entities);
    }
}
