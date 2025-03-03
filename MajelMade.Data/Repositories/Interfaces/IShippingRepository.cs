using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface IShippingRepository
    {
        Task<IEnumerable<Shipping>> GetAllAsync();
        Task<Shipping?> GetByIdAsync(int shippingId);
        Task AddAsync(Shipping shipping);
        void Update(Shipping shipping);
        void Delete(Shipping shipping);
        Task SaveAsync();
    }
}
