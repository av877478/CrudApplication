using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }


        public DbSet<EmployeeMaster> EmployeeMasters { get; set; }

    }
}