using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirmPracticeArea;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.GetAll;

public class GetAllLawFirmPracticeAreaQueryHandler : IRequestHandler<GetAllLawFirmPracticeAreaQuery, List<LawFirmPracticeAreaDto>>
{
    private readonly ILawFirmPracticeAreaQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllLawFirmPracticeAreaQueryHandler(IMapper mapper, ILawFirmPracticeAreaQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<LawFirmPracticeAreaDto>> Handle(GetAllLawFirmPracticeAreaQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<LawFirmPracticeAreaDto>>(entities);
    }
}

