using Microsoft.AspNetCore.Mvc;
using X_Technology_ORTv2.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
        public async Task<IActionResult> Index()
        {
            return RedirectToAction("Admin");
        }

        public async Task<IActionResult> Admin()
        {
            return View(await _context.OrdersHeader.ToListAsync());
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
         * GET | Checkout
         * Se recibe el Id del producto clickeado para comprar
         */
        public async Task<IActionResult> Checkout(int id)
        {
            return View(await _context.Products.FindAsync(id));
        }

        // GET | Delete Order Header
        public async Task<IActionResult> Delete(int id)
        {
            OrderHeader orderHeader = await _context.OrdersHeader.FindAsync(id);
            if (orderHeader != null)
            {
                return View(orderHeader);
            }
            return View("Failed");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            var orderHeaders = _context.OrdersHeader.Where(o => o.Id == id).Include(o => o.Details);
            if (orderHeaders.Count() > 0)
            {
                var orderHeader = orderHeaders.First();
                DeleteOrderHeader(orderHeader);
                return RedirectToAction("Admin", "Orders");
            }
            return View("Failed");
        }

        private void DeleteOrderHeader(OrderHeader orderHeader)
        {
            DeleteOrdersDetails(orderHeader.Details);
            _context.OrdersHeader.Remove(orderHeader);
            _context.SaveChanges();
        }

        private void DeleteOrdersDetails(List<OrderDetail> details)
        {
            foreach (OrderDetail orderDetail in details)
            {
                _context.OrdersDetails.Remove(orderDetail);
            }
            _context.SaveChanges();
        }
    }

}