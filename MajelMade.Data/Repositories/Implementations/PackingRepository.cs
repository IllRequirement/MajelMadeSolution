using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Domain.Entities;
using MajelMade.Data.Repositories.Interfaces;

namespace MajelMade.Data.Repositories.Implementations
{
    public class PackingRepository : IPackingRepository
    {
        private readonly MajelMadeDbContext _context;

        public PackingRepository(MajelMadeDbContext context)
        {
            _context = context;
        }

        public async Task AddPackingDetailsAsync(PackingDetails packingDetails)
        {
            await _context.PackingDetails.AddAsync(packingDetails);
        }

        public async Task<PackingDetails?> GetPackingDetailsByIdAsync(int packingId)
        {
            return await _context.PackingDetails.FindAsync(packingId);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
