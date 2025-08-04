using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.AcademicInfo;
using lawyer.api.shared.application.DTO;
using MediatR;

namespace lawyer.api.shared.application.UseCases.AcademicInfo.GetAll;

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
