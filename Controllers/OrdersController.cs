using Microsoft.AspNetCore.Mvc;
using X_Technology_ORTv2.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;

namespace X_Technology_ORTv2.Controllers
{
    public class OrdersController : Controller
    {
        /**
         * Listar órdenes (OMS)
         */
        private readonly Context _context;
        public OrdersController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Admin");
        }

       public async Task<IActionResult> Admin()
        {
            return View(await _context.OrdersHeader.ToListAsync());
        }

        public async Billing getBilling(int id)
        {
            return await _context.Billings.FindAsync(id);
        }
        /**
         * Crear nueva orden y retorna a una vista de success o
         * failed según corresponda
         */
        public IActionResult New()
        {
            var Result = false;

            if (Result)
            {
                return View("Success");
            }
            else
            {
                return View("Failed");
            }
            
        }

        /**
         * Formulario de compra
         */
        public IActionResult Checkout()
        {
            return View();
        }
    }

}