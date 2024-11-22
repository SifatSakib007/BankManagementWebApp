namespace BankManagement.Models
{
    public class Loan
    {
        public int Id { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public User User { get; set; } = null!;
        public string LoanType { get; set; } 
        public decimal Amount { get; set; } // Required
        public decimal InterestRate { get; set; } // Percentage
        public string RepaymentSchedule { get; set; } = string.Empty; // JSON/Serialized
        public string Status { get; set; }  // Enum: Pending, Approved, Rejected
        public decimal Penalty { get; set; } = 0; // Default
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
