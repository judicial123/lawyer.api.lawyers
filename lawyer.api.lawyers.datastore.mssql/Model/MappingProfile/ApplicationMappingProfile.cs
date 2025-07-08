using AutoMapper;
using lawyer.api.lawyers.domain;
using lawyer.api.lawyers.datastore.mssql.Model;

namespace lawyer.api.lawyers.datastore.mssql.Model.MappingProfile;

public class ApplicationMappingProfile : Profile
{
    public ApplicationMappingProfile()
    {
        CreateMap<Lawyer, LawyerEntity>().ReverseMap();
        CreateMap<AcademicInfo, AcademicInfoEntity>().ReverseMap();
        CreateMap<Example, ExampleEntity>().ReverseMap();
    }
}
