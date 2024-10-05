using AgroSmart.Core.Application.Dtos.API.Topic;
using AgroSmart.Core.Domain.Entities;
using AutoMapper;

namespace AgroSmart.Core.Application.Mappings
{
    public class TopicProfile : Profile
    {
        public TopicProfile()
        {
            // Mapeo de Topic a TopicDto y viceversa
            CreateMap<Topic, TopicDto>().ReverseMap(); // De Topic a TopicDto y viceversa

            // Mapeo de Topic a SaveTopicDto y viceversa
            CreateMap<Topic, SaveTopicDto>().ReverseMap(); // De Topic a SaveTopicDto y viceversa
        }
    }
}
