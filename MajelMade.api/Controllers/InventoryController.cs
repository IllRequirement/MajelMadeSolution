using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MajelMade.Domain.Entities;
using MajelMade.BusinessLogic.Interfaces;

namespace MajelMade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateInventory([FromBody] Inventory inventory)
        {
            if (inventory == null)
            {
                return BadRequest("Inventory data is required.");
            }

            var createdInventory = await _inventoryService.AddInventoryAsync(inventory);
            return Ok(createdInventory);
        }
    }
}
