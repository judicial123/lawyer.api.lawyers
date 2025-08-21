using AutoMapper;
using lawyer.api.lawyers.application.DTO;
using lawyer.api.lawyers.application.UseCases.Comment.Create;
using lawyer.api.lawyers.application.UseCases.Comment.Update;
using lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Common.MappingProfiles;

public class CommentProfile : Profile
{
    public CommentProfile()
    {
        CreateMap<CommentDto, Comment>().ReverseMap();
        CreateMap<CreateCommentCommand, Comment>().ReverseMap();
        CreateMap<UpdateCommentCommand, Comment>().ReverseMap();
    }
}
