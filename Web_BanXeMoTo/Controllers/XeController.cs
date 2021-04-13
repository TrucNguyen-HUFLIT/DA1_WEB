using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class XeController : Controller
    {

        QLMoToContext db = new QLMoToContext();

        public  IActionResult Index()
        {
            return View(db.MauXes.ToList());
        }

    }
}
