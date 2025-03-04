using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Implementations
{
    public class InventoryRepository : GenericRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(MajelMadeDbContext context) : base(context)
        {
        }

        public async Task<Inventory?> GetByScannableLabelIdAsync(int scannableLabelId)
        {
            return await _context.Inventories
                                 .FirstOrDefaultAsync(i => i.ScannableLabelID == scannableLabelId);
        }
    }
}
