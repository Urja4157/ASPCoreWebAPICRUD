using Microsoft.EntityFrameworkCore;

namespace ASPCoreWebAPICRUD.Models
{
    public class MyNewDbContext : DbContext
    {
        public MyNewDbContext(DbContextOptions<MyNewDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        
    }
    
}
