using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.AcademicInfo;
using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.AcademicInfo.GetAll;

public class GetAllAcademicInfoQueryHandler : IRequestHandler<GetAllAcademicInfoQuery, List<AcademicInfoDto>>
{
    private readonly IAcademicInfoQueryRepository _infoQuery;
    private readonly IMapper _mapper;

    public GetAllAcademicInfoQueryHandler(
        IMapper mapper,
        IAcademicInfoQueryRepository infoQuery)
    {
        _mapper = mapper;
        _infoQuery = infoQuery;
    }

    public async Task<List<AcademicInfoDto>> Handle(GetAllAcademicInfoQuery request, CancellationToken cancellationToken)
    {
        var infos = await _infoQuery.GetAllAsync();
        var data = _mapper.Map<List<AcademicInfoDto>>(infos);
        return data;
    }
}
