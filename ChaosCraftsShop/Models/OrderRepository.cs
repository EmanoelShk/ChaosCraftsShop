namespace ChaosCraftsShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ChaosCraftsShopDbContext _chaosCraftsShopDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(ChaosCraftsShopDbContext chaosCraftsShopDbContext, IShoppingCart shoppingCart)
        {
            _chaosCraftsShopDbContext = chaosCraftsShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            //adding the order with its details

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    Price = shoppingCartItem.Product.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _chaosCraftsShopDbContext.Orders.Add(order);

            _chaosCraftsShopDbContext.SaveChanges();
        }
    }
}
