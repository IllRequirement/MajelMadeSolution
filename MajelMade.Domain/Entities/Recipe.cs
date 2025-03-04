using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public required string RecipeName { get; set; }
        public string? Instructions { get; set; }
        public decimal EstimatedPrepTimeMinutes { get; set; }
        public decimal EstimatedCost { get; set; }
        public int ServingSize { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserID { get; set; }

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
        public ICollection<RecipeEquipment> RecipeEquipment { get; set; } = new List<RecipeEquipment>();
        public ICollection<RecipeStep> RecipeSteps { get; set; } = new List<RecipeStep>();
        public User? User { get; set; }
    }
}
