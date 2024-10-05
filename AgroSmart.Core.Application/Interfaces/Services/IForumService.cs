using AgroSmart.Core.Application.Dtos.API.Post;
using AgroSmart.Core.Application.Dtos.API.Topic;

namespace AgroSmart.Core.Application.Interfaces.Services
{
    public interface IForumService
    {
        Task<IEnumerable<TopicDto>> GetAllTopicsAsync();
        Task<TopicDto> GetTopicByIdAsync(int id);
        Task CreateTopicAsync(SaveTopicDto model);
        Task AddPostToTopicAsync(SavePostDto model);
    }
}
