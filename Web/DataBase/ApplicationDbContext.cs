using Microsoft.EntityFrameworkCore;
using Store;

namespace Web.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<FavoritesProducts> FavoritesProducts { get; set; }
        public DbSet<ClientProfile> ClientProfile { get; set; }
        public DbSet<ClientOrders> ClientOrders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Cart { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SPT5FRR;database=Site;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False");
        }
    }
}
