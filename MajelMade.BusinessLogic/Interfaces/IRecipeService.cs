using System.Threading.Tasks;
using MajelMade.Domain.Entities;

namespace MajelMade.BusinessLogic.Interfaces
{
    public interface IRecipeService
    {
        Task<Recipe> AddRecipeAsync(Recipe recipe);
        Task<Recipe?> GetRecipeAsync(int recipeId);  // Allow null if not found
        Task LogRecipeStepAsync(int recipeId, RecipeStepLog log);
    }
}
