using System;
using System.Collections.Generic;

namespace MajelMade.Api.Dtos
{
    public class RecipeCreateDto
    {
        // Basic recipe properties
        public required string RecipeName { get; set; }
        public required string Instructions { get; set; }
        public decimal EstimatedPrepTimeMinutes { get; set; }
        public decimal EstimatedCost { get; set; }
        public int ServingSize { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserID { get; set; }

        // Lists for child items (without navigation properties)
        public List<RecipeIngredientDto> RecipeIngredients { get; set; } = new List<RecipeIngredientDto>();
        public List<RecipeEquipmentDto> RecipeEquipment { get; set; } = new List<RecipeEquipmentDto>();
        public List<RecipeStepDto> RecipeSteps { get; set; } = new List<RecipeStepDto>();
    }

    // DTO for recipe ingredients
    public class RecipeIngredientDto
    {
        public int InventoryID { get; set; }
        public decimal QuantityRequired { get; set; }
        public int MeasurementUnitID { get; set; }
        public required string CodeID { get; set; }
        public bool NeedsReorder { get; set; }
    }

    // DTO for recipe equipment
    public class RecipeEquipmentDto
    {
        public int EquipmentID { get; set; }
        public required string Notes { get; set; }
    }

    // DTO for recipe steps
    public class RecipeStepDto
    {
        public int StepNumber { get; set; }
        public required string Description { get; set; }
        public decimal EstimatedTimeMinutes { get; set; }
        public decimal EstimatedCost { get; set; }
        public required string AdditionalNotes { get; set; }
    }
}
