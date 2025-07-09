using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.AcademicInfo;
using ${SolutionName}.Application.DTO;
using MediatR;

namespace ${SolutionName}.Application.UseCases.AcademicInfo.GetById;

public class GetByIdAcademicInfoQueryHandler : IRequestHandler<GetByIdAcademicInfoQuery, AcademicInfoDto>
{
    private readonly IMapper _mapper;
    private readonly IAcademicInfoQueryRepository _query;

    public GetByIdAcademicInfoQueryHandler(
        IMapper mapper,
        IAcademicInfoQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<AcademicInfoDto> Handle(GetByIdAcademicInfoQuery request, CancellationToken cancellationToken)
    {
        var info = await _query.GetByIdAsync(request.Id);
        var data = _mapper.Map<AcademicInfoDto>(info);
        return data;
    }
}
