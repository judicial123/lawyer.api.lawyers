using AutoMapper;
using lawyer.api.shared.application.DTO;
using lawyer.api.shared.application.UseCases.Example.Create;
using lawyer.api.shared.application.UseCases.Example.Update;
using lawyer.api.shared.domain;

namespace lawyer.api.shared.application.Common.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleDto, Example>().ReverseMap();
        CreateMap<CreateExampleCommand, Example>().ReverseMap();
        CreateMap<UpdateExampleCommand, Example>().ReverseMap();
    }
}
