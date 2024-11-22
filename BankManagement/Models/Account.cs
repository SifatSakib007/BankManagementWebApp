namespace BankManagement.Models
{
    public class Account
    {
        public int Id { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public User User { get; set; } = null!;
        public string AccountType { get; set; } 
        public string Currency { get; set; } = "USD"; // Example: USD, EUR, BDT
        public decimal Balance { get; set; } = 0; // Required
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
