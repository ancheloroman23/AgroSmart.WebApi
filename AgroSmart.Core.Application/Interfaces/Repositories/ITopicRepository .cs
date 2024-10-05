using AgroSmart.Core.Domain.Entities;

namespace AgroSmart.Core.Application.Interfaces.Repositories
{
    public interface ITopicRepository : IGenericRepository<Topic>
    {
        Task<IEnumerable<Topic>> GetTopicsByUserIdAsync(string userId);
    }
}
