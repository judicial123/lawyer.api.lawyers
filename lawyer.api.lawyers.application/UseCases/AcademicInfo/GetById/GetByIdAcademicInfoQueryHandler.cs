using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.AcademicInfo;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.AcademicInfo.GetById;

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
