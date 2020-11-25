using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using X_Technology_ORTv2.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using X_Technology_ORTv2.ViewModels;

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
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrdersDetails.ToListAsync());
        }

        /**
         * Crear nueva orden y retorna a una vista de success o
         * failed según corresponda
         */
        [HttpPost]
        public IActionResult New(OrderHeaderViewModel model)
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