using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirm;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirm.GetAll;

public class GetAllLawFirmsQueryHandler : IRequestHandler<GetAllLawFirmsQuery, List<LawFirmDto>>
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

    public async Task<List<LawFirmDto>> Handle(GetAllLawFirmsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<LawFirmDto>>(entities);
    }
}
