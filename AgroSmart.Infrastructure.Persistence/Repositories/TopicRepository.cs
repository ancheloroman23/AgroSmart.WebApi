using AgroSmart.Core.Application.Interfaces.Repositories;
using AgroSmart.Core.Domain.Entities;
using AgroSmart.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgroSmart.Infraestructure.Persistence.Repositories
{
    public class TopicRepository : GenericRepository<Topic>, ITopicRepository
    {
        private readonly ApplicationContext _dbcontext;

        public TopicRepository(ApplicationContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // Método específico para Topic
        public async Task<IEnumerable<Topic>> GetTopicsByUserIdAsync(string userId)
        {
            return await _dbcontext.Topics.Where(t => t.UserId == userId).ToListAsync();
        }
    }
}
