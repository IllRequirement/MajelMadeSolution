using System.Threading.Tasks;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Services
{
    public class RecipeService(IRecipeRepository _recipeRepository) : IRecipeService
    {
        public async Task<Recipe> AddRecipeAsync(Recipe recipe)
        {
            await _recipeRepository.AddAsync(recipe);
            await _recipeRepository.SaveAsync();
            return recipe;
        }

        public async Task<Recipe?> GetRecipeAsync(int recipeId)
        {
            return await _recipeRepository.GetByIdAsync(recipeId);
        }

        public async Task LogRecipeStepAsync(int recipeId, RecipeStepLog log)
        {
            await _recipeRepository.LogRecipeStepAsync(recipeId, log);
        }
    }
}
