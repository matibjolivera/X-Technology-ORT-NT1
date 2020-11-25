using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace X_Technology_ORTv2.Controllers
{
    public class UsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}