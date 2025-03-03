using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Implementations
{
    public class InventoryRepository(MajelMadeDbContext _context) : IInventoryRepository
    {
        public async Task<Inventory?> GetByScannableLabelIdAsync(int scannableLabelId)
        {
            return await _context.Inventories
                                 .FirstOrDefaultAsync(i => i.ScannableLabelID == scannableLabelId);
        }
    }
}
