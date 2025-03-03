using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IGenericRepository<OrderStatusHistory> _orderStatusHistoryRepository;
        private readonly IGenericRepository<StatusType> _statusTypeRepository;

        // The service now depends on repository abstractions instead of the DbContext directly.
        public OrderService(
            IOrderRepository orderRepository,
            IGenericRepository<OrderStatusHistory> orderStatusHistoryRepository,
            IGenericRepository<StatusType> statusTypeRepository)
        {
            _orderRepository = orderRepository;
            _orderStatusHistoryRepository = orderStatusHistoryRepository;
            _statusTypeRepository = statusTypeRepository;
        }

        public async Task<Order> GetOrderByLabelAsync(int scannableLabelId)
        {
            // Using a repository method that supports querying by predicate.
            Order? order = await _orderRepository.GetFirstOrDefaultAsync(o => o.ScannableLabelID == scannableLabelId);
            if (order == null)
            {
                throw new InvalidOperationException($"No order found with label ID {scannableLabelId}");
            }
            return order;
        }

        public async Task UpdateOrderStatusAsync(int orderId, int newStatusTypeId)
        {
            // Retrieve the order using the repository.
            Order? order = await _orderRepository.GetByIdAsync(orderId);
            if (order == null)
            {
                throw new InvalidOperationException($"No order found with ID {orderId}");
            }

            // Retrieve the StatusType entity using the generic repository.
            StatusType? statusType = await _statusTypeRepository.GetByIdAsync(newStatusTypeId);
            if (statusType == null)
            {
                throw new InvalidOperationException($"Invalid status type ID: {newStatusTypeId}");
            }

            // Create the OrderStatusHistory record, setting its required navigation properties.
            var statusHistory = new OrderStatusHistory
            {
                OrderID = orderId,
                StatusTypeID = newStatusTypeId,
                UpdatedDateTime = DateTime.UtcNow,
                Notes = "Status updated via OrderService",
                Order = order,
                StatusType = statusType
            };

            await _orderStatusHistoryRepository.AddAsync(statusHistory);
            await _orderStatusHistoryRepository.SaveAsync();
        }
    }
}
