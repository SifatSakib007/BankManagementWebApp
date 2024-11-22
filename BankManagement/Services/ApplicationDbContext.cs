using Microsoft.EntityFrameworkCore;

namespace BankManagement.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
