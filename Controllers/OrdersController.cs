using System;
using System.Diagnostics;
using System.Linq;
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
            var productId = model.ProductId;
            var productsSelect = from m in _context.Products select m;
            var products = productsSelect.Where(p => p.Id.Equals(productId)).ToList();
            var product = products.Find(p => p.Id.Equals(productId));

            if (product != null)
            {
                Billing billingTmp = model.Billing;
                Shipping shippingTmp = model.Shipping;

                OrderHeader orderHeader = new OrderHeader(product.Price, "MercadoPago", "OCA", billingTmp, shippingTmp);
                Billing billing = new Billing(billingTmp.Firstname, billingTmp.Lastname, billingTmp.Document,
                    billingTmp.Email);
                Shipping shipping = new Shipping(shippingTmp.Firstname, shippingTmp.Lastname, shippingTmp.Address,
                    shippingTmp.ZipCode, shippingTmp.ExtraInformation, shippingTmp.Province, shippingTmp.City);
                OrderDetail orderDetail = new OrderDetail(product);
                
                orderHeader.Details.Add(orderDetail);
        
                _context.Billings.Add(billing);
                _context.Shippings.Add(shipping);
                _context.OrdersHeader.Add(orderHeader);

                _context.SaveChanges();
            }

            return View("Index");
        }

        /**
         * Formulario de compra
         */
        [HttpGet]
        public IActionResult Checkout()
        {
            ViewData["ProductId"] = Request.Form["ProductId"];

            return View();
        }
    }
}