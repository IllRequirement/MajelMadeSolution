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

        public RecipeRepository(MajelMadeDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
        }

        public async Task<Recipe?> GetByIdAsync(int recipeId)
        {
            return await _context.Recipes
                .Include(r => r.RecipeStepLogs)
                .Include(r => r.RecipeIngredients)
                .Include(r => r.RecipeEquipment)
                .FirstOrDefaultAsync(r => r.RecipeID == recipeId);
        }

        public async Task LogRecipeStepAsync(int recipeStepId, RecipeStepLog log)
        {
            // Retrieve the RecipeStep associated with the provided recipeStepId
            var recipeStep = await _context.RecipeSteps
                                           .Include(rs => rs.Recipe) // Ensure Recipe is included
                                           .FirstOrDefaultAsync(rs => rs.RecipeStepID == recipeStepId);

            if (recipeStep == null)
            {
                throw new ArgumentException("Recipe step not found.");
            }

            // Associate the log with the retrieved RecipeStep
            log.RecipeStepID = recipeStepId;
            log.RecipeStep = recipeStep;

            // Add the log entry to the context
            await _context.RecipeStepLogs.AddAsync(log);

            // Save changes to the database
            await _context.SaveChangesAsync();
        }


        public async Task<IEnumerable<Recipe>> GetAllAsync()
        {
            return await _context.Recipes
                .Include(r => r.RecipeStepLogs)
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
