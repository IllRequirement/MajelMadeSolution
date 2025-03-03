using Microsoft.AspNetCore.Mvc;
using MajelMade.BusinessLogic.Interfaces;
using System.Threading.Tasks;

namespace MajelMade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModificationTypesController : ControllerBase
    {
        private readonly IModificationTypeService _modificationTypeService;

        public ModificationTypesController(IModificationTypeService modificationTypeService)
        {
            _modificationTypeService = modificationTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetModificationTypes()
        {
            var modificationTypes = await _modificationTypeService.GetAllModificationTypesAsync();
            return Ok(modificationTypes);
        }
    }
}
