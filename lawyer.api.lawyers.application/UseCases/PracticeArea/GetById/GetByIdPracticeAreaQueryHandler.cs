using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.PracticeArea;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.GetById;

public class GetByIdPracticeAreaQueryHandler : IRequestHandler<GetByIdPracticeAreaQuery, PracticeAreaDto>
{
    private readonly IPracticeAreaQueryRepository _query;
    private readonly IMapper _mapper;

    public GetByIdPracticeAreaQueryHandler(IPracticeAreaQueryRepository query, IMapper mapper)
    {
        _query = query;
        _mapper = mapper;
    }

    public async Task<PracticeAreaDto> Handle(GetByIdPracticeAreaQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<PracticeAreaDto>(entity);
    }
}
