using AutoMapper;
using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.PracticeArea.Create;
using lawyer.api.lawyers.application.UseCases.PracticeArea.Update;
using lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Common.MappingProfiles;

public class PracticeAreaProfile : Profile
{
    public PracticeAreaProfile()
    {
        CreateMap<PracticeAreaDto, PracticeArea>().ReverseMap();
        CreateMap<CreatePracticeAreaCommand, PracticeArea>().ReverseMap();
        CreateMap<UpdatePracticeAreaCommand, PracticeArea>().ReverseMap();
    }
}
