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

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
