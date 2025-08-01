using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Lawyer.GetById;

public class GetByIdLawyerQueryHandler : IRequestHandler<GetByIdLawyerQuery, LawyerQueryDto>
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

    public async Task<LawyerQueryDto> Handle(GetByIdLawyerQuery request, CancellationToken cancellationToken)
    {
        var lawyer = await _query.GetByIdAsync(request.Id, "AcademicInfos");
        var data = _mapper.Map<LawyerQueryDto>(lawyer);
        return data;
    }
}