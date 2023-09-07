using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChaosCraftsShop.Models
{
    public class ChaosCraftsShopDbContext : IdentityDbContext
    {
        public ChaosCraftsShopDbContext(DbContextOptions<ChaosCraftsShopDbContext>
            options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
