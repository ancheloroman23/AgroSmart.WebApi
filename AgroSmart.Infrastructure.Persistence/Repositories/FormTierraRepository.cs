using AgroSmart.Core.Application.Interfaces.Repositories;
using AgroSmart.Core.Domain.Entities;
using AgroSmart.Infraestructure.Persistence.Context;

namespace AgroSmart.Infraestructure.Persistence.Repositories
{
    public class FormTierraRepository : GenericRepository<FormTierra>, IFormTierraRepository
    {
        private readonly ApplicationContext _dbcontext;

        public FormTierraRepository(ApplicationContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task AddTierraAsync(FormTierra tierra)
        {
            await _dbcontext.FormTierras.AddAsync(tierra);
            await _dbcontext.SaveChangesAsync();
        }
    }
}

