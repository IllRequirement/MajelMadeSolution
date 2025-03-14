namespace MajelMade.Domain.Entities;

public class Recipe(string recipeName, decimal estimatedPrepTimeMinutes, decimal estimatedCost, int servingSize, DateTime dateCreated, int userId, User user)
{
    public int RecipeID { get; set; }
    public string RecipeName { get; set; } = recipeName;
    public string? Instructions { get; set; }
    public decimal EstimatedPrepTimeMinutes { get; set; }
    public decimal EstimatedCost { get; set; }
    public int ServingSize { get; set; }
    public DateTime DateCreated { get; set; }
    public int UserID { get; set; } = userId;
    public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    public ICollection<RecipeEquipment> RecipeEquipment { get; set; } = new List<RecipeEquipment>();
    public ICollection<RecipeStep> RecipeSteps { get; set; } = new List<RecipeStep>();
    public ICollection<RecipeStepLog> RecipeStepLogs { get; set; } = new List<RecipeStepLog>();

    public User User { get; set; } = user;
}