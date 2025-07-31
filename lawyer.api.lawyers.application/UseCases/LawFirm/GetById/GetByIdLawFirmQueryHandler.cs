using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirm;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirm.GetById;

public class GetByIdLawFirmQueryHandler : IRequestHandler<GetByIdLawFirmQuery, LawFirmQueryDto>
{
    private readonly IMapper _mapper;
    private readonly ILawFirmQueryRepository _query;

    public GetByIdLawFirmQueryHandler(
        IMapper mapper,
        ILawFirmQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<LawFirmQueryDto> Handle(GetByIdLawFirmQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id, "Lawyers");
        return _mapper.Map<LawFirmQueryDto>(entity);
    }
}
