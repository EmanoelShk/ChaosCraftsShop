namespace ChaosCraftsShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ChaosCraftsShopDbContext _chaosCraftsShopDbContext;

        public CategoryRepository(ChaosCraftsShopDbContext chaosCraftsShopDbContext)
        {
            _chaosCraftsShopDbContext = chaosCraftsShopDbContext;
        }

        public IEnumerable<Category> AllCategories =>
            _chaosCraftsShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
