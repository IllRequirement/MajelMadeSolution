using System;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory> AddInventoryAsync(Inventory inventory)
        {
            // Set the LastUpdated property to the current UTC time
            inventory.LastUpdated = DateTime.UtcNow;
            await _inventoryRepository.AddAsync(inventory);
            await _inventoryRepository.SaveAsync();
            return inventory;
        }

        public async Task<Inventory?> GetInventoryByLabelAsync(int scannableLabelId)
        {
            return await _inventoryRepository.GetByScannableLabelIdAsync(scannableLabelId);
        }
    }
}
