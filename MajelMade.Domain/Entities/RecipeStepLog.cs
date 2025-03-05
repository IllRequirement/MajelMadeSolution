using System;

namespace MajelMade.Domain.Entities
{
    public class RecipeStepLog
    {
        public int RecipeStepLogID { get; set; }
        public int RecipeStepID { get; set; }
        public DateTime ExecutionDate { get; set; }
        public decimal ActualTimeMinutes { get; set; }
        public decimal ActualCost { get; set; }
        public int ExecutedByUserID { get; set; }
        public required string Comments { get; set; }

        // Navigation property
        public Recipe Recipe { get; set; } = null!;
        public required RecipeStep RecipeStep { get; set; }
    }
}
