using AgroSmart.Core.Application.Dtos.API.Topic;
using AgroSmart.Core.Application.Features.Topic.Queries;
using AgroSmart.Core.Application.Interfaces.Repositories;
using AutoMapper;

namespace AgroSmart.Core.Application.Features.Topic.QueryHandlers
{
    public class GetAllTopicsQueryHandler
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IMapper _mapper;

        public GetAllTopicsQueryHandler(ITopicRepository topicRepository, IMapper mapper)
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TopicDto>> Handle(GetAllTopicsQuery query)
        {
            var topics = await _topicRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TopicDto>>(topics);
        }
    }
}
