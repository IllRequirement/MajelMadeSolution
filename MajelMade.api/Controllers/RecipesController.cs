using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        // POST: api/Recipes
        [HttpPost]
        public async Task<IActionResult> CreateRecipe([FromBody] Recipe recipe)
        {
            // (Validation logic can be added here)
            var createdRecipe = await _recipeService.AddRecipeAsync(recipe);
            return CreatedAtAction(nameof(GetRecipe), new { id = createdRecipe.RecipeID }, createdRecipe);
        }

        // GET: api/Recipes/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecipe(int id)
        {
            var recipe = await _recipeService.GetRecipeAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }
    }
}
