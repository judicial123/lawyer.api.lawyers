using AutoMapper;
using ${SolutionName}.Application.DTO;
using ${SolutionName}.Application.UseCases.AcademicInfo.Create;
using ${SolutionName}.Application.UseCases.AcademicInfo.Update;
using ${SolutionName}.Domain;

namespace ${SolutionName}.Application.Common.MappingProfiles;

public class AcademicInfoProfile : Profile
{
    public AcademicInfoProfile()
    {
        CreateMap<AcademicInfoDto, AcademicInfo>().ReverseMap();
        CreateMap<CreateAcademicInfoCommand, AcademicInfo>().ReverseMap();
        CreateMap<UpdateAcademicInfoCommand, AcademicInfo>().ReverseMap();
    }
}

