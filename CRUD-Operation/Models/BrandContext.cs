using Microsoft.EntityFrameworkCore;

namespace CRUD_Operation.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext>option) : base(option)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
    }
}
