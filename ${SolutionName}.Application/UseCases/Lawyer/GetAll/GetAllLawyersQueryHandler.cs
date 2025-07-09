using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Lawyer;
using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.Lawyer.GetAll;

public class GetAllLawyersQueryHandler : IRequestHandler<GetAllLawyersQuery, List<LawyerDto>>
{
    private readonly ILawyerQueryRepository _lawyerQuery;
    private readonly IMapper _mapper;

    public GetAllLawyersQueryHandler(
        IMapper mapper,
        ILawyerQueryRepository lawyerQuery)
    {
        _mapper = mapper;
        _lawyerQuery = lawyerQuery;
    }

    public async Task<List<LawyerDto>> Handle(GetAllLawyersQuery request, CancellationToken cancellationToken)
    {
        var lawyers = await _lawyerQuery.GetAllAsync();
        var data = _mapper.Map<List<LawyerDto>>(lawyers);
        return data;
    }}