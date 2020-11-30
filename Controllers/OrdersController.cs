using System.Linq;
using Microsoft.AspNetCore.Mvc;
using X_Technology_ORTv2.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using X_Technology_ORTv2.ViewModels;
using System.Collections.Generic;
using X_Technology_ORTv2.Utils;
using System;

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

            if (product != null && hasErrors(model) != false)
            {
                OrderHeader orderHeader = new OrderHeader(product.Price, model.PaymentMethod, model.ShippingMethod, model.Billing, model.Shipping);
                OrderDetail orderDetail = new OrderDetail(product);

                orderHeader.Details.Add(orderDetail);

                await _context.OrdersHeader.AddAsync(orderHeader);

                await _context.SaveChangesAsync();

                return View("Success");
            }
            return View("Failed");
        }

        private bool hasErrors(OrderHeaderViewModel model)
        {
           return StringsUtil.ValidateString(model.PaymentMethod) && StringsUtil.ValidateString(model.ShippingMethod) &&
                ValidateShipping(model.Shipping) && ValidateBilling(model.Billing);
        }

        private bool ValidateShipping(Shipping shipping)
        {
            return shipping != null && StringsUtil.ValidateString(shipping.Address) && StringsUtil.ValidateString(shipping.City)
                && StringsUtil.ValidateString(shipping.Firstname) && StringsUtil.ValidateString(shipping.Lastname)
                && StringsUtil.ValidateString(shipping.Province) && StringsUtil.ValidateString(shipping.ZipCode);
        }

        private bool ValidateBilling(Billing billing)
        {
            return billing != null && StringsUtil.ValidateString(billing.Document) && StringsUtil.ValidateString(billing.Email)
                && StringsUtil.ValidateString(billing.Firstname) && StringsUtil.ValidateString(billing.Lastname);
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