using Microsoft.EntityFrameworkCore;

namespace CrudInAsp.netCore.Models
{
    public class TransactionDbContext:DbContext
    {
        //constructor for this class
        public TransactionDbContext(DbContextOptions<TransactionDbContext>options):base(options) { 
        }
        public DbSet<Transaction> transactions { get; set; }
        
    }
}
