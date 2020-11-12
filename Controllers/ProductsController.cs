using Microsoft.AspNetCore.Mvc;

namespace X_Technology_ORTv2.Controllers
{
    public class ProductsController : Controller
    {
        /**
         * Listado de productos
         */
        public IActionResult Index()
        {
            return View();
        }
        
        /**
         * Vista de un producto en especifico
         */
        public IActionResult Show()
        {
            return View();
        }
    }
}