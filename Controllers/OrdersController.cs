using System.Linq;
using Microsoft.AspNetCore.Mvc;
using X_Technology_ORTv2.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using X_Technology_ORTv2.ViewModels;
using System.Collections.Generic;

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

        public IActionResult Admin()
        {
            return View(_context.OrdersHeader
                .Include(oh => oh.Shipping)
                .Include(oh => oh.Billing)
                .Include(oh => oh.Details)
                    .ThenInclude(od => od.Product));
        }

        /**
         * Crear nueva orden y retorna a una vista de success o
         * failed según corresponda
         */
        [HttpPost]
        public async Task<IActionResult> New(OrderHeaderViewModel model)
        {
            Product product = await _context.Products.FindAsync(model.ProductId);

            if (product != null)
            {
                Billing billingTmp = model.Billing;
                Shipping shippingTmp = model.Shipping;

                OrderHeader orderHeader = new OrderHeader(product.Price, "MercadoPago", "OCA", billingTmp, shippingTmp);
                OrderDetail orderDetail = new OrderDetail(product);

                orderHeader.Details.Add(orderDetail);

                await _context.OrdersHeader.AddAsync(orderHeader);

                await _context.SaveChangesAsync();
            }

            return View("Success");
        }

        /**
         * GET | Checkout
         * Se recibe el Id del producto clickeado para comprar
         */
        public IActionResult Checkout(int id)
        {
            ViewData["ProductId"] = id;

            return View();
        }

        // GET | Delete Order Header
        public async Task<IActionResult> Delete(int id)
        {
            OrderHeader orderHeader = await _context.OrdersHeader.FindAsync(id);
            return orderHeader != null ? View(orderHeader) : View("Failed");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            var orderHeaders = _context.OrdersHeader.Where(o => o.Id == id).Include(o => o.Details);
            if (orderHeaders.Any())
            {
                var orderHeader = orderHeaders.First();
                DeleteOrderHeader(orderHeader);
                return RedirectToAction("Admin", "Orders");
            }
            ViewBag.message = "No se encontró la venta a eliminar.";
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