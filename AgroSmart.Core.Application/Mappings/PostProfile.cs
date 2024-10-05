using AgroSmart.Core.Application.Dtos.API.Post;
using AgroSmart.Core.Domain.Entities;
using AutoMapper;

namespace AgroSmart.Core.Application.Mappings
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            // Mapeo de Post a PostDto y viceversa
            CreateMap<Post, PostDto>().ReverseMap(); // De Post a PostDto y viceversa

            // Mapeo de Post a SavePostDto y viceversa
            CreateMap<Post, SavePostDto>().ReverseMap(); // De Post a SavePostDto y viceversa
        }
    }
}
