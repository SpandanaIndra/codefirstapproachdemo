using Microsoft.EntityFrameworkCore;

namespace CodeFirst_Demo1.Models
{
    public class SDetailsDbContext:DbContext
    {
        public SDetailsDbContext(DbContextOptions<SDetailsDbContext> option):base(option) 
        {
            
        }
        public DbSet<Student> Student { get; set; }
    }
}
