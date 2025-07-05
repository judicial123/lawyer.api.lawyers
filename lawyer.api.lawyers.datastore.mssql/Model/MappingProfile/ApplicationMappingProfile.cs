using AutoMapper;
using lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.datastore.mssql.Model.MappingProfile;

public class ApplicationMappingProfile : Profile
{
    public ApplicationMappingProfile()
    {
        CreateMap<Lawyer, LawyerEntity>().ReverseMap();
    }
}