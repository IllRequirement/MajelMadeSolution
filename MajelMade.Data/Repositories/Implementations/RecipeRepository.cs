using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajelMade.Data.Contexts;
using MajelMade.Domain.Entities;
using MajelMade.Data.Repositories.Interfaces;

namespace MajelMade.Data.Repositories.Implementations
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly MajelMadeDbContext _context;
        public async Task AddAsync(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
        }

        public async Task<Recipe?> GetByIdAsync(int recipeId)
        {
            // Include related collections as needed (for example, steps and ingredients)
            return await _context.Recipes
                .Include(r => r.RecipeSteps)
                .Include(r => r.RecipeIngredients)
                .Include(r => r.RecipeEquipment)
                .FirstOrDefaultAsync(r => r.RecipeID == recipeId);
        }

        public async Task LogRecipeStepAsync(int recipeId, RecipeStepLog log)
        {
            var recipe = await _context.Recipes.Include(r => r.Steps)
                                               .FirstOrDefaultAsync(r => r.Id == recipeId);
            if (recipe == null) throw new ArgumentException("Recipe not found.");

            log.RecipeId = recipeId;
            await _context.RecipeStepLogs.AddAsync(log);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Recipe>> GetAllAsync()
        {
            return await _context.Recipes
                .Include(r => r.RecipeSteps)
                .Include(r => r.RecipeIngredients)
                .Include(r => r.RecipeEquipment)
                .ToListAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
