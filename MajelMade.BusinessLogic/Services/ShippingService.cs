using System.Collections.Generic;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Services
{
    public class ShippingService : IShippingService
    {
        private readonly IShippingRepository _shippingRepository;

        public ShippingService(IShippingRepository shippingRepository)
        {
            _shippingRepository = shippingRepository;
        }

        public async Task<IEnumerable<Shipping>> GetAllShippingAsync()
        {
            return await _shippingRepository.GetAllAsync();
        }

        public async Task<Shipping?> GetShippingByIdAsync(int shippingId)
        {
            return await _shippingRepository.GetByIdAsync(shippingId);
        }

        public async Task<Shipping> AddShippingAsync(Shipping shipping)
        {
            await _shippingRepository.AddAsync(shipping);
            await _shippingRepository.SaveAsync();
            return shipping;
        }

        public async Task UpdateShippingAsync(Shipping shipping)
        {
            _shippingRepository.Update(shipping);
            await _shippingRepository.SaveAsync();
        }

        public async Task DeleteShippingAsync(int shippingId)
        {
            var shipping = await _shippingRepository.GetByIdAsync(shippingId);
            if (shipping != null)
            {
                _shippingRepository.Delete(shipping);
                await _shippingRepository.SaveAsync();
            }
        }
    }
}
