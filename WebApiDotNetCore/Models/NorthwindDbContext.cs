using Microsoft.EntityFrameworkCore;

namespace WebApiDotNetCore.Models
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public NorthwindDbContext()
        {

        }

        public NorthwindDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
