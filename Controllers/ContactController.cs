using Microsoft.AspNetCore.Mvc;

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
        public void SendMessage()
        {
            
        }
    }
}