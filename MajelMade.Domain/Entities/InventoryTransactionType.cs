namespace MajelMade.Domain.Entities
{
    public class InventoryTransactionType(int inventoryTransactionTypeID, string transactionTypeName)
    {
        public int InventoryTransactionTypeID { get; set; } = inventoryTransactionTypeID;
        public string TransactionTypeName { get; set; } = transactionTypeName;
    }
}
