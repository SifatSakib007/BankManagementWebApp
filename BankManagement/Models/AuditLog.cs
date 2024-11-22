namespace BankManagement.Models
{
    public class AuditLog
    {
        public int Id { get; set; } // Primary Key
        public string Action { get; set; } = string.Empty; // Example: "LargeTransfer"
        public int? UserId { get; set; } // Foreign Key (nullable for system actions)
        public User? User { get; set; }
        public string Details { get; set; } = string.Empty; // JSON/Serialized
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
