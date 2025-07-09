using AutoMapper;
using ${SolutionName}.Application.DTO;
using ${SolutionName}.Application.UseCases.Lawyer.Create;
using ${SolutionName}.Application.UseCases.Lawyer.Update;
using ${SolutionName}.Domain;

namespace ${SolutionName}.Application.Common.MappingProfiles;

public class LawyerProfile : Profile
{
    public LawyerProfile()
    {
        CreateMap<LawyerDto, Lawyer>().ReverseMap();
        CreateMap<CreateLawyerCommand, Lawyer>().ReverseMap();
        CreateMap<UpdateLawyerCommand, Lawyer>().ReverseMap();
    }}