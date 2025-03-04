namespace MajelMade.Domain.Entities
{
    public class RecipeStep
    {
        public int RecipeStepID { get; set; }
        public int RecipeID { get; set; }
        public int StepNumber { get; set; }
        public required string Description { get; set; }
        public decimal EstimatedTimeMinutes { get; set; }
        public decimal EstimatedCost { get; set; }
        public string? AdditionalNotes { get; set; }
        public ICollection<RecipeStep> RecipeSteps { get; set; } = new List<RecipeStep>();
        public required Recipe Recipe { get; set; }
    }
}
