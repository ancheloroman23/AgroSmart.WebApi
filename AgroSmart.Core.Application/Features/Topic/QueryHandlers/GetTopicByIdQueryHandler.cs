using AgroSmart.Core.Application.Dtos.API.Topic;
using AgroSmart.Core.Application.Features.Topic.Queries;
using AgroSmart.Core.Application.Interfaces.Repositories;
using AutoMapper;

namespace AgroSmart.Core.Application.Features.Topic.QueryHandlers
{
    public class GetTopicByIdQueryHandler
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IMapper _mapper;

        public GetTopicByIdQueryHandler(ITopicRepository topicRepository, IMapper mapper)
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
        }

        public async Task<TopicDto> Handle(GetTopicByIdQuery query)
        {
            var topic = await _topicRepository.GetByIdAsync(query.Id);
            return _mapper.Map<TopicDto>(topic);
        }
    }
}
