using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;


namespace Web_BanXeMoTo.Controllers
{
    public class BookingController : Controller
    {
        private readonly QLMoToContext database;
        private readonly IWebHostEnvironment hostEnvironment;

        public BookingController(QLMoToContext db)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            return View(model);
            //return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(DatLich datlich)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            if (ModelState.IsValid)
            {
                database.Add(datlich);
                await database.SaveChangesAsync();
                return RedirectToAction("Products");
            }
            return View(model);
        }

        public ActionResult SelectMau()
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            return View(model);

            //Category se_cate = new Category();
            //se_cate.Listcate = database.Category.ToList<Category>();
            //return PartialView(se_cate);
        }
    }
}
