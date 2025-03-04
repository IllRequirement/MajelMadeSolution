using System.Threading.Tasks;
using MajelMade.Domain.Entities;
using System.Collections.Generic;

namespace MajelMade.Data.Repositories.Interfaces
{
    public interface IRecipeRepository
    {
        // Adds a new Recipe to the data store.
        Task AddAsync(Recipe recipe);

        // Retrieves a Recipe by its ID (with related data if needed).
        Task<Recipe?> GetByIdAsync(int recipeId);

        // Optionally, you could include additional methods, for example:
        Task<IEnumerable<Recipe>> GetAllAsync();

        Task LogRecipeStepAsync(int recipeId, RecipeStepLog log);

        // Saves changes to the data store.
        Task SaveAsync();
    }
}
