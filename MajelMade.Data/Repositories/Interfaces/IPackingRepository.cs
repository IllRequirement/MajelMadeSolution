using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface IPackingRepository
    {
        // Adds a new PackingDetails record to the data store.
        Task AddPackingDetailsAsync(PackingDetails packingDetails);

        // Retrieves a PackingDetails record by its ID.
        Task<PackingDetails?> GetPackingDetailsByIdAsync(int packingId);

        // Saves changes to the data store.
        Task SaveAsync();
    }
}
