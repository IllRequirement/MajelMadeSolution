using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using MajelMade.Domain.Entities;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order?> GetFirstOrDefaultAsync(Expression<Func<Order, bool>> predicate);
        Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(int customerId);
    }
}
