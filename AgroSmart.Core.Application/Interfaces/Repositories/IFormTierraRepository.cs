using AgroSmart.Core.Domain.Entities;

namespace AgroSmart.Core.Application.Interfaces.Repositories
{
    public interface IFormTierraRepository
    {
        Task AddTierraAsync(FormTierra tierra);
    }
}
