using AutoMapper;
using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.Lawyer.Create;
using lawyer.api.lawyers.application.UseCases.Lawyer.Update;
using lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Common.MappingProfiles;

public class LawyerProfile : Profile
{
    public LawyerProfile()
    {
        CreateMap<LawyerDto, Lawyer>().ReverseMap();
        CreateMap<CreateLawyerCommand, Lawyer>().ReverseMap();
        CreateMap<UpdateLawyerCommand, Lawyer>().ReverseMap();
    }
}