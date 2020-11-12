using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X_Technology_ORTv2.Models;

namespace X_Technology_ORTv2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Context _context;

        public ProductsController(Context context)
        {
            _context = context;
        }
        
        /**
         * Listado de productos
         */
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
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