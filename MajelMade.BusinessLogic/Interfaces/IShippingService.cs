using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface IShippingService
    {
        Task<IEnumerable<Shipping>> GetAllShippingAsync();
        Task<Shipping?> GetShippingByIdAsync(int shippingId);
        Task<Shipping> AddShippingAsync(Shipping shipping);
        Task UpdateShippingAsync(Shipping shipping);
        Task DeleteShippingAsync(int shippingId);
    }
}
