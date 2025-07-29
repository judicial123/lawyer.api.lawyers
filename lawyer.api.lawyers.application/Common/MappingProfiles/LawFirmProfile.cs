using AutoMapper;
using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.LawFirm.Create;
using lawyer.api.lawyers.application.UseCases.LawFirm.Update;
using lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Common.MappingProfiles;

public class LawFirmProfile : Profile
{
    public LawFirmProfile()
    {
        CreateMap<LawFirmDto, LawFirm>().ReverseMap();
        CreateMap<CreateLawFirmCommand, LawFirm>().ReverseMap();
        CreateMap<UpdateLawFirmCommand, LawFirm>().ReverseMap();
    }
}