using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Lawyer;
using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.Lawyer.GetById;

public class GetByIdLawyerQueryHandler : IRequestHandler<GetByIdLawyerQuery, LawyerDto>
{
    private readonly IMapper _mapper;
    private readonly ILawyerQueryRepository _query;

    public GetByIdLawyerQueryHandler(
        IMapper mapper,
        ILawyerQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<LawyerDto> Handle(GetByIdLawyerQuery request, CancellationToken cancellationToken)
    {
        var lawyer = await _query.GetByIdAsync(request.Id);
        var data = _mapper.Map<LawyerDto>(lawyer);
        return data;
    }}