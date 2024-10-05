using AgroSmart.Core.Application.Dtos.API.Post;
using AgroSmart.Core.Application.Dtos.API.Topic;
using AgroSmart.Core.Domain.Entities;
using AutoMapper;

namespace AgroSmart.Core.Application.Mappings
{
    public class ForumProfile : Profile
    {
        public ForumProfile() 
        {
            // Mapeo de Topic a TopicDTO
            CreateMap<Topic, TopicDto>()
                .ForMember(dest => dest.UserName, opt => opt.Ignore()); // Ignorar el mapeo del nombre de usuario aquí

            // Mapeo de SaveTopicDTO a Topic
            CreateMap<SaveTopicDto, Topic>();

            // Mapeo de Post a PostDTO
            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.UserName, opt => opt.Ignore()); // Ignorar el mapeo del nombre de usuario aquí

            // Mapeo de SavePostDTO a Post
            CreateMap<SavePostDto, Post>();
        }        
    }
}
