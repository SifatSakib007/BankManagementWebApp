namespace BankManagement.Models
{
    public class Notification
    {
        public int Id { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public User User { get; set; } = null!;
        public string Message { get; set; } = string.Empty; // Required
        public bool IsRead { get; set; } = false; // Default
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
