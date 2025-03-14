namespace MajelMade.Domain.Entities
{
    public class RecipeStep(int recipeStepId, int recipeId, int stepNumber, string description)
    {
        // Primary constructor properties initialization
        public int RecipeStepID { get; set; } = recipeStepId;
        public int RecipeID { get; set; } = recipeId;
        public int StepNumber { get; set; } = stepNumber;
        public string Description { get; set; } = description;

        // Parameterless constructor for EF Core
        public RecipeStep() : this(0, 0, 0, string.Empty) { }

        public decimal EstimatedTimeMinutes { get; set; }
        public decimal EstimatedCost { get; set; }
        public string? AdditionalNotes { get; set; }

        // Navigation properties
        public required Recipe Recipe { get; set; }
        public ICollection<RecipeStepLog> RecipeStepLogs { get; set; } = new List<RecipeStepLog>();
    }
}