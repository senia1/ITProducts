using ITProductsWeb.Data;
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
            var objProductList = _db.Products.ToList();
            return View();
        }
    }
}
