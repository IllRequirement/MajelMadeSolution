using Microsoft.AspNetCore.Mvc;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Domain.Entities;
using System.Threading.Tasks;

namespace MajelMade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("by-label/{labelId}")]
        public async Task<IActionResult> GetOrderByLabel(int labelId)
        {
            try
            {
                var order = await _orderService.GetOrderByLabelAsync(labelId);
                return Ok(order);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("{orderId}/status/{statusId}")]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, int statusId)
        {
            await _orderService.UpdateOrderStatusAsync(orderId, statusId);
            return NoContent();
        }
    }
}
