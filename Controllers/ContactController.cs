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
            ViewBag.message = "Algo ha ocurrido! Los datos no se pudieron enviar correctamente.";
            ViewBag.type = "danger";
            if (ModelState.IsValid)
            {
                ViewBag.message = "Datos enviados exitosamente!";
                ViewBag.type = "success";
                ModelState.Clear();
            }
            return View("Index");
        }
    }
}