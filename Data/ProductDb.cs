using CoreAPI2.Modal;
using Microsoft.EntityFrameworkCore;

namespace CoreAPI2.Data
{
    public class ProductDb : DbContext
    {
        public ProductDb(DbContextOptions<ProductDb>options):base(options) { 
        
        }

        public DbSet<Product>Products { get; set; }
    }
}
