using AgroSmart.Core.Application.Dtos.Accounts;
using AgroSmart.Core.Application.Dtos.API.Post;
using AgroSmart.Core.Application.Dtos.API.Topic;
using AgroSmart.Core.Application.Features.Post.CommandHandlers;
using AgroSmart.Core.Application.Features.Post.Commands;
using AgroSmart.Core.Application.Features.Topic.CommandHandlers;
using AgroSmart.Core.Application.Features.Topic.Commands;
using AgroSmart.Core.Application.Features.Topic.Queries;
using AgroSmart.Core.Application.Features.Topic.QueryHandlers;
using AgroSmart.Core.Application.Interfaces.Services;

namespace AgroSmart.Core.Application.Services
{
    public class ForumService : IForumService
    {
        private readonly CreateTopicCommandHandler _createTopicHandler;
        private readonly AddPostCommandHandler _addPostHandler;
        private readonly GetAllTopicsQueryHandler _getAllTopicsHandler;
        private readonly GetTopicByIdQueryHandler _getTopicByIdHandler;

        public ForumService(CreateTopicCommandHandler createTopicHandler,
                            AddPostCommandHandler addPostHandler,
                            GetAllTopicsQueryHandler getAllTopicsHandler,
                            GetTopicByIdQueryHandler getTopicByIdHandler)
        {
            _createTopicHandler = createTopicHandler;
            _addPostHandler = addPostHandler;
            _getAllTopicsHandler = getAllTopicsHandler;
            _getTopicByIdHandler = getTopicByIdHandler;
        }

        public async Task<IEnumerable<TopicDto>> GetAllTopicsAsync()
        {
            var query = new GetAllTopicsQuery();
            return await _getAllTopicsHandler.Handle(query);
        }

        public async Task<TopicDto> GetTopicByIdAsync(int id)
        {
            var query = new GetTopicByIdQuery { Id = id };
            return await _getTopicByIdHandler.Handle(query);
        }

        public async Task CreateTopicAsync(SaveTopicDto model)
        {
            var command = new CreateTopicCommand { Model = model };
            await _createTopicHandler.Handle(command);
        }

        public async Task AddPostToTopicAsync(SavePostDto model)
        {
            var command = new AddPostCommand { Model = model };
            await _addPostHandler.Handle(command);
        }
    }
}

