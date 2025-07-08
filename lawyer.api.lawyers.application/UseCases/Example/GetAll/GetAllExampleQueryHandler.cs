using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Example.GetAll;

public class GetAllExampleQueryHandler : IRequestHandler<GetAllExampleQuery, List<ExampleDto>>
{
    private readonly IExampleQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllExampleQueryHandler(
        IMapper mapper,
        IExampleQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<ExampleDto>> Handle(GetAllExampleQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<ExampleDto>>(entities);
    }
}
