using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Domain.Entities;
using System.Collections.Generic;

namespace MajelMade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService _shippingService;

        public ShippingController(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }

        // GET: api/Shipping
        [HttpGet]
        public async Task<IActionResult> GetShipping()
        {
            IEnumerable<Shipping> shippingList = await _shippingService.GetAllShippingAsync();
            return Ok(shippingList);
        }

        // GET: api/Shipping/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShippingById(int id)
        {
            Shipping? shipping = await _shippingService.GetShippingByIdAsync(id);
            if (shipping == null)
                return NotFound();

            return Ok(shipping);
        }

        // POST: api/Shipping
        [HttpPost]
        public async Task<IActionResult> CreateShipping([FromBody] Shipping shipping)
        {
            if (shipping == null)
                return BadRequest();

            var createdShipping = await _shippingService.AddShippingAsync(shipping);
            return CreatedAtAction(nameof(GetShippingById), new { id = createdShipping.ShippingID }, createdShipping);
        }

        // PUT: api/Shipping/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShipping(int id, [FromBody] Shipping shipping)
        {
            if (id != shipping.ShippingID)
                return BadRequest("ID mismatch");

            await _shippingService.UpdateShippingAsync(shipping);
            return NoContent();
        }

        // DELETE: api/Shipping/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShipping(int id)
        {
            await _shippingService.DeleteShippingAsync(id);
            return NoContent();
        }
    }
}
