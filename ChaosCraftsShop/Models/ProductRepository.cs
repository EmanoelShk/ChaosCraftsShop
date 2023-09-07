using Microsoft.EntityFrameworkCore;

namespace ChaosCraftsShop.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ChaosCraftsShopDbContext _chaosCraftsDbContext;

        public ProductRepository(ChaosCraftsShopDbContext context) 
        {
            _chaosCraftsDbContext = context;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return _chaosCraftsDbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> ProductsOfTheWeek
        {
            get
            {
                return _chaosCraftsDbContext.Products.Include(c => c.Category).Where(p =>
                    p.IsProductOfTheWeek);
            }
        }

        public Product? GetProductById(int productId)
        {
            return _chaosCraftsDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public IEnumerable<Product> SearchProducts(string searchQuery)
        {
            return _chaosCraftsDbContext.Products.Where(p => p.Name.Contains(searchQuery));
        }
    }
}
