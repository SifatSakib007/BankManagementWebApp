namespace BankManagement.Models
{
    public class Backup
    {
        public int Id { get; set; } // Primary Key
        public string FilePath { get; set; } = string.Empty; // Required
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
