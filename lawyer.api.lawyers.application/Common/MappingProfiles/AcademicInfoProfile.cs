using AutoMapper;
using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.AcademicInfo.Create;
using lawyer.api.lawyers.application.UseCases.AcademicInfo.Update;
using lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Common.MappingProfiles;

public class AcademicInfoProfile : Profile
{
    public AcademicInfoProfile()
    {
        CreateMap<AcademicInfoDto, AcademicInfo>().ReverseMap();
        CreateMap<CreateAcademicInfoCommand, AcademicInfo>().ReverseMap();
        CreateMap<UpdateAcademicInfoCommand, AcademicInfo>().ReverseMap();
    }
}

