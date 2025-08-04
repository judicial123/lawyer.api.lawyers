using AutoMapper;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.application.UseCases.LawFirm.Create;
using lawyer.api.shared.application.UseCases.LawFirm.Update;
using lawyer.api.shared.domain;

namespace lawyer.api.shared.application.Common.MappingProfiles;

public class LawFirmProfile : Profile
{
    public LawFirmProfile()
    {
        CreateMap<LawFirmDto, LawFirm>().ReverseMap();
        CreateMap<LawFirmQueryDto, LawFirm>().ReverseMap();
        CreateMap<CreateLawFirmCommand, LawFirm>().ReverseMap();
        CreateMap<UpdateLawFirmCommand, LawFirm>().ReverseMap();
    }
}