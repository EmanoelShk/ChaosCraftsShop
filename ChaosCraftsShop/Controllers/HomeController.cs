using ChaosCraftsShop.Models;
using ChaosCraftsShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ChaosCraftsShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var productsOfTheWeek = _productRepository.ProductsOfTheWeek;
            var homeViewModel = new HomeViewModel(productsOfTheWeek);
            return View(homeViewModel);
        }
    }
}
