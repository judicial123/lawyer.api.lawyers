using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.PracticeArea;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.GetAll;

public class GetAllPracticeAreaQueryHandler : IRequestHandler<GetAllPracticeAreaQuery, List<PracticeAreaDto>>
{
    private readonly IPracticeAreaQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllPracticeAreaQueryHandler(IPracticeAreaQueryRepository query, IMapper mapper)
    {
        _query = query;
        _mapper = mapper;
    }

    public async Task<List<PracticeAreaDto>> Handle(GetAllPracticeAreaQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<PracticeAreaDto>>(entities);
    }
}
