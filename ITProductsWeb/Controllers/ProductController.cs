using Microsoft.AspNetCore.Mvc;

namespace ITProductsWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
