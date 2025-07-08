using AutoMapper;
using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.Example.Create;
using lawyer.api.lawyers.application.UseCases.Example.Update;
using lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Common.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleDto, Example>().ReverseMap();
        CreateMap<CreateExampleCommand, Example>().ReverseMap();
        CreateMap<UpdateExampleCommand, Example>().ReverseMap();
    }
}
