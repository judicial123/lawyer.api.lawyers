using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirmPracticeArea;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.GetById;

public class GetByIdLawFirmPracticeAreaQueryHandler : IRequestHandler<GetByIdLawFirmPracticeAreaQuery, LawFirmPracticeAreaDto>
{
    private readonly ILawFirmPracticeAreaQueryRepository _query;
    private readonly IMapper _mapper;

    public GetByIdLawFirmPracticeAreaQueryHandler(ILawFirmPracticeAreaQueryRepository query, IMapper mapper)
    {
        _query = query;
        _mapper = mapper;
    }

    public async Task<LawFirmPracticeAreaDto> Handle(GetByIdLawFirmPracticeAreaQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<LawFirmPracticeAreaDto>(entity);
    }
}

