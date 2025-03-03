using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Domain.Entities;
using MajelMade.Data.Repositories.Interfaces;

namespace MajelMade.Data.Repositories.Implementations
{
    public class ShippingRepository : IShippingRepository
    {
        private readonly MajelMadeDbContext _context;

        public ShippingRepository(MajelMadeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Shipping>> GetAllAsync()
        {
            return await _context.Shipping
                .Include(s => s.Order)
                .Include(s => s.ShippingMethodType)
                .Include(s => s.StatusType)
                .ToListAsync();
        }

        public async Task<Shipping?> GetByIdAsync(int shippingId)
        {
            return await _context.Shipping
                .Include(s => s.Order)
                .Include(s => s.ShippingMethodType)
                .Include(s => s.StatusType)
                .FirstOrDefaultAsync(s => s.ShippingID == shippingId);
        }

        public async Task AddAsync(Shipping shipping)
        {
            await _context.Shipping.AddAsync(shipping);
        }

        public void Update(Shipping shipping)
        {
            _context.Shipping.Update(shipping);
        }

        public void Delete(Shipping shipping)
        {
            _context.Shipping.Remove(shipping);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
