using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface IOrderService
    {
        Task<Order> GetOrderByLabelAsync(int scannableLabelId);
        Task UpdateOrderStatusAsync(int orderId, int newStatusTypeId);
    }
}
