using AutoMapper;
using ${SolutionName}.Domain;
using ${SolutionName}.Infrastructure.Model;

namespace ${SolutionName}.Infrastructure.Model.MappingProfile;

public class ApplicationMappingProfile : Profile
{
    public ApplicationMappingProfile()
    {
        CreateMap<Lawyer, LawyerEntity>().ReverseMap();
        CreateMap<AcademicInfo, AcademicInfoEntity>().ReverseMap();
        CreateMap<Example, ExampleEntity>().ReverseMap();
    }
}
