using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Lawyer;
using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.Lawyer.GetAll;

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