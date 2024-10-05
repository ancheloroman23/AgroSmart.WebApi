using AgroSmart.Core.Domain.Entities;

namespace AgroSmart.Core.Application.Interfaces.Repositories
{
    public interface IFormTierraRepository : IGenericRepository<FormTierra>
    {
        Task AddTierraAsync(FormTierra tierra);
    }
}
