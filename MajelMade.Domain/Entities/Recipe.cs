using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string RecipeName { get; set; } = string.Empty;
        public string? Instructions { get; set; }
        public decimal EstimatedPrepTimeMinutes { get; set; }
        public decimal EstimatedCost { get; set; }
        public int ServingSize { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserID { get; set; }

        // Navigation properties
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
        public ICollection<RecipeEquipment> RecipeEquipment { get; set; } = new List<RecipeEquipment>();
        public ICollection<RecipeStepLog> RecipeStepLogs { get; set; } = new List<RecipeStepLog>();

        public User User { get; set; } = null!;
    }
}
