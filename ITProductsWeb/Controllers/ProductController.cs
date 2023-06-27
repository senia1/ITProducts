using ITProductsWeb.Data;
using ITProductsWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITProductsWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsDbContext _db;

        public ProductController(ProductsDbContext db)
        {
            _db = db;  
        }
        public IActionResult Index()
        {
            IEnumerable<Product> objProductList = _db.Products;
            return View(objProductList);
        }
    }
}
