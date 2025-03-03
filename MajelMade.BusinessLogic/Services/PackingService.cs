using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Services
{
    public class PackingService : IPackingService
    {
        private readonly IPackingRepository _packingRepository;

        public PackingService(IPackingRepository packingRepository)
        {
            _packingRepository = packingRepository;
        }

        public async Task<PackingDetails> CreatePackingAsync(PackingDetails packingDetails)
        {
            // You might want to set additional properties here (e.g. timestamps)
            await _packingRepository.AddPackingDetailsAsync(packingDetails);
            await _packingRepository.SaveAsync();
            return packingDetails;
        }

        public async Task<PackingDetails?> GetPackingDetailsAsync(int packingId)
        {
            return await _packingRepository.GetPackingDetailsByIdAsync(packingId);
        }
    }
}
