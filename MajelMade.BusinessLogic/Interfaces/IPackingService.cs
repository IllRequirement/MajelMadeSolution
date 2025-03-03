using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface IPackingService
    {
        Task<PackingDetails> CreatePackingAsync(PackingDetails packingDetails);
        Task<PackingDetails?> GetPackingDetailsAsync(int packingId);
    }
}
