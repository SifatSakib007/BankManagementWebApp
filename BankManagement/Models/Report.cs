namespace BankManagement.Models
{
    public class Report
    {
        public int Id { get; set; } // Primary Key
        public int AccountId { get; set; } // Foreign Key
        public Account Account { get; set; } = null!;
        public string ReportType { get; set; } 
        public string Data { get; set; } = string.Empty; // JSON/Serialized
        public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;
    }
}
