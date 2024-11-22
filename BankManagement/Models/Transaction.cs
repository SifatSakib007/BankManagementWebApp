namespace BankManagement.Models
{
    public class Transaction
    {
        public int Id { get; set; } // Primary Key
        public int AccountId { get; set; } // Foreign Key
        public Account Account { get; set; } = null!;
        public string Type { get; set; } 
        public decimal Amount { get; set; } // Required
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow; // Auto-generated
        public int? RecipientAccountId { get; set; } // Nullable for non-transfer transactions
        public Account? RecipientAccount { get; set; }
        public string? Description { get; set; } // Optional
        public decimal Fee { get; set; } = 0; // Default
    }
}
