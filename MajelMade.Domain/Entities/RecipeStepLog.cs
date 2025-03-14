namespace MajelMade.Domain.Entities;

public class RecipeStepLog(int recipeStepID, DateTime executionDate, decimal actualTimeMinutes, decimal actualCost, int executedByUserID, string comments, Recipe recipe, RecipeStep recipeStep)
{
    public int RecipeStepLogID { get; set; }
    public int RecipeStepID { get; set; } = recipeStepID;
    public DateTime ExecutionDate { get; set; } = executionDate;
    public decimal ActualTimeMinutes { get; set; } = actualTimeMinutes;
    public decimal ActualCost { get; set; } = actualCost;
    public int ExecutedByUserID { get; set; } = executedByUserID;
    public string Comments { get; set; } = comments;

    // Navigation properties
    public Recipe Recipe { get; set; }
    public RecipeStep RecipeStep { get; set; }
}
