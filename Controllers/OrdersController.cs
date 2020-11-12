using Microsoft.AspNetCore.Mvc;

namespace X_Technology_ORTv2.Controllers
{
    public class OrdersController : Controller
    {
        /**
         * Listar órdenes (OMS)
         */
        public IActionResult Index()
        {
            return View();
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