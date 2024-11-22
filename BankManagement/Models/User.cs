using System.Data;

namespace BankManagement.Models
{
    public class User
    {
        public int Id { get; set; } // Primary Key
        public string Username { get; set; } = string.Empty; // Required
        public string PasswordHash { get; set; } = string.Empty; // Required
        public string Email { get; set; } = string.Empty; // Required, Unique
        public string? PhoneNumber { get; set; } // Optional
        public string? Role { get; set; } // Enum: Admin, Employee, Customer
        public bool TwoFactorEnabled { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
