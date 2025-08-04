using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.LawFirm;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.application.UseCases.LawFirm.GetAll;
using MediatR;

namespace lawyer.api.shared.application.UseCases.LawFirm.GetAllBasic;

public class GetAllBasicLawFirmsQueryHandler  : IRequestHandler<GetAllBasicLawFirmsQuery, List<LawFirmDto>>
{
    private readonly ILawFirmQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllBasicLawFirmsQueryHandler(
        IMapper mapper,
        ILawFirmQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<LawFirmDto>> Handle(GetAllBasicLawFirmsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync("Lawyers");
        return _mapper.Map<List<LawFirmDto>>(entities);
    }
}