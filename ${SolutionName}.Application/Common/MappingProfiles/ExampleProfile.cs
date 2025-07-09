using AutoMapper;
using ${SolutionName}.Application.DTO;
using ${SolutionName}.Application.UseCases.Example.Create;
using ${SolutionName}.Application.UseCases.Example.Update;
using ${SolutionName}.Domain;

namespace ${SolutionName}.Application.Common.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleDto, Example>().ReverseMap();
        CreateMap<CreateExampleCommand, Example>().ReverseMap();
        CreateMap<UpdateExampleCommand, Example>().ReverseMap();
    }
}
