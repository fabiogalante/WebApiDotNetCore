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

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=NORTHWND;User ID=sa;Password=Amil2014**;MultipleActiveResultSets=true");
        }
    }
}
