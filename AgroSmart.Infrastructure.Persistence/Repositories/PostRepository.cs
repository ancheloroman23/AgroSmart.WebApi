using AgroSmart.Core.Application.Interfaces.Repositories;
using AgroSmart.Core.Domain.Entities;
using AgroSmart.Infraestructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AgroSmart.Infraestructure.Persistence.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        private readonly ApplicationContext _dbcontext;

        public PostRepository(ApplicationContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<Post>> GetPostsByTopicIdAsync(int topicId)
        {
            return await _dbcontext.Posts.Where(p => p.TopicId == topicId).ToListAsync();
        }
    }
}
