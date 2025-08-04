using AutoMapper;
using lawyer.api.shared.domain;
using lawyer.api.shared.datastore.mssql.Model;

namespace lawyer.api.shared.datastore.mssql.Model.MappingProfile;

public class ApplicationMappingProfile : Profile
{
    public ApplicationMappingProfile()
    {
        CreateMap<Lawyer, LawyerEntity>().ReverseMap();
        CreateMap<AcademicInfo, AcademicInfoEntity>().ReverseMap();
        CreateMap<Example, ExampleEntity>().ReverseMap();
        CreateMap<LawFirm, LawFirmEntity>().ReverseMap();
    }
}
