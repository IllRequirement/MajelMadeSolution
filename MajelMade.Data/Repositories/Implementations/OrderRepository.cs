using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MajelMade.Data.Contexts;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MajelMade.Data.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<Order?> GetFirstOrDefaultAsync(Expression<Func<Order, bool>> predicate)
        {
            return await _context.Orders.FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(int customerId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .Where(o => o.CustomerID == customerId)
                .ToListAsync();
        }
    }
}
