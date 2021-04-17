using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_BanXeMoTo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult ProductsDetail()
        {
            return View();
        }
    }
}
