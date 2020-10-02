using Microsoft.EntityFrameworkCore;

namespace AspNetMvcFromScratch.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<> MyProperty { get; set; }
    }
}
