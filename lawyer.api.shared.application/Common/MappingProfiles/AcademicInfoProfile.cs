using AutoMapper;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.application.UseCases.AcademicInfo.Create;
using lawyer.api.shared.application.UseCases.AcademicInfo.Update;
using lawyer.api.shared.domain;

namespace lawyer.api.shared.application.Common.MappingProfiles;

public class AcademicInfoProfile : Profile
{
    public AcademicInfoProfile()
    {
        CreateMap<AcademicInfoDto, AcademicInfo>().ReverseMap();
        CreateMap<CreateAcademicInfoCommand, AcademicInfo>().ReverseMap();
        CreateMap<UpdateAcademicInfoCommand, AcademicInfo>().ReverseMap();
    }
}

