using AutoMapper;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.application.UseCases.Lawyer.Create;
using lawyer.api.shared.application.UseCases.Lawyer.Update;
using lawyer.api.shared.domain;

namespace lawyer.api.shared.application.Common.MappingProfiles;

public class LawyerProfile : Profile
{
    public LawyerProfile()
    {
        CreateMap<LawyerDto, Lawyer>().ReverseMap();
        CreateMap<LawyerQueryDto, Lawyer>().ReverseMap();
        CreateMap<CreateLawyerCommand, Lawyer>().ReverseMap();
        CreateMap<UpdateLawyerCommand, Lawyer>().ReverseMap();
    }
}