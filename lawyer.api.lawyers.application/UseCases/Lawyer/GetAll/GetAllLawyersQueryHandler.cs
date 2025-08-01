using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Lawyer.GetAll;

public class GetAllLawyersQueryHandler : IRequestHandler<GetAllLawyersQuery, List<LawyerQueryDto>>
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

    public async Task<List<LawyerQueryDto>> Handle(GetAllLawyersQuery request, CancellationToken cancellationToken)
    {
        var lawyers = await _lawyerQuery.GetAllAsync("AcademicInfos");
        var data = _mapper.Map<List<LawyerQueryDto>>(lawyers);
        return data;
    }
}