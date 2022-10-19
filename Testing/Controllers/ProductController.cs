using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        //get controller
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
