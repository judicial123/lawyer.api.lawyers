using AutoMapper;
using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.Create;
using lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.Update;
using lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Common.MappingProfiles;

public class LawFirmPracticeAreaProfile : Profile
{
    public LawFirmPracticeAreaProfile()
    {
        CreateMap<LawFirmPracticeAreaDto, LawFirmPracticeArea>().ReverseMap();
        CreateMap<CreateLawFirmPracticeAreaCommand, LawFirmPracticeArea>().ReverseMap();
        CreateMap<UpdateLawFirmPracticeAreaCommand, LawFirmPracticeArea>().ReverseMap();
    }
}

