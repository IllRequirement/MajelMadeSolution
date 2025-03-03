using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface IInventoryService
    {
        Task<Inventory> AddInventoryAsync(Inventory inventory);
        Task<Inventory?> GetInventoryByLabelAsync(int scannableLabelId);
    }
}
