using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using X_Technology_ORTv2.Models;

namespace X_Technology_ORTv2.Controllers
{
    public class ContactController : Controller
    {
        /**
         * Mostrar formulario de contacto
         */
        public IActionResult Index()
        {
            return View();
        }

        /**
         * Enviar mensaje
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendMessage(MailMessage mailMessage)
        {
            ViewBag.message = "Verify your message!";
            ViewBag.type = "danger";
            if (ModelState.IsValid)
            {
                ViewBag.message = "Your message was sent successfully";
                ViewBag.type = "success";
            }
            return View("Index");
        }
    }
}