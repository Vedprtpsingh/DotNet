using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        // Example table
        public DbSet<Products> Products { get; set; }
    }
}
