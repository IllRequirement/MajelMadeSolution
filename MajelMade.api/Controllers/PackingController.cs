using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Domain.Entities;
using MajelMade.BusinessLogic.Services;

namespace MajelMade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PackingController : ControllerBase
    {
        private readonly IPackingService _packingService;

        public PackingController(IPackingService packingService)
        {
            _packingService = packingService;
        }

        // POST: api/Packing
        [HttpPost]
        public async Task<IActionResult> CreatePacking([FromBody] PackingDetails packingDetails)
        {
            // You might add validation here
            var createdPacking = await _packingService.CreatePackingAsync(packingDetails);
            return CreatedAtAction(nameof(GetPacking), new { id = createdPacking.PackingID }, createdPacking);
        }

        // GET: api/Packing/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPacking(int id)
        {
            var packing = await _packingService.GetPackingDetailsAsync(id);
            if (packing == null)
            {
                return NotFound();
            }
            return Ok(packing);
        }
    }
}
