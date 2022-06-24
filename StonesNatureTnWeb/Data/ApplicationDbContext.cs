using Microsoft.EntityFrameworkCore;
using StonesNatureTnWeb.Models;

namespace StonesNatureTnWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
        public DbSet<ProductSize> ProductSize { get; set; }
    }
}
