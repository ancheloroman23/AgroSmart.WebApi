using AgroSmart.Core.Domain.Entities;

namespace AgroSmart.Core.Application.Interfaces.Repositories
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsByTopicIdAsync(int topicId);
    }
}
