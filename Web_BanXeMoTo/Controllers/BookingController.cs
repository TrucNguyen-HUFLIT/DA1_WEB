using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
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
        public IActionResult BookingList(/*int id*/)
        {
            //var email =HttpContext.Session.GetString("email");

            var model = new ViewModelCus();
            model.ListDatLich = database.DatLiches.ToArray();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhachHang = database.KhachHangs/*.Where(x=>x.Idkh==id)*/.ToArray();
            return View(model);
        }
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Login", "Login");
            }
            var model = new ViewModelCus();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhachHang = database.KhachHangs.ToArray();
            return View(model);
            //return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DatLich datlich)
        {
            var model = new ViewModelCus();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhachHang = database.KhachHangs.ToArray();
            if (ModelState.IsValid)
            {
                database.Add(datlich);
                await database.SaveChangesAsync();
                return RedirectToAction("Products", "Products");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var model = new ViewModelCus();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhachHang = database.KhachHangs.ToArray();
            model.datLich = database.DatLiches.Where(x => x.IddatLich == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id, DatLich datLich)
        {
            datLich = database.DatLiches.Where(x => x.IddatLich == id).FirstOrDefault();
            database.Remove(datLich);
            database.SaveChanges();
            return RedirectToAction("BookingList");
        }
        public IActionResult Edit(int id)
        {

            var model = new ViewModelCus();
            model.ListDatLich = database.DatLiches.ToArray();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhachHang = database.KhachHangs.ToArray();
            model.datLich = database.DatLiches.Where(x => x.IddatLich == id).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, DatLich datLich)
        {
            var model = new ViewModelCus();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            model.ListKhachHang = database.KhachHangs.ToArray();
            model.datLich = database.DatLiches.Where(x => x.IddatLich == id).FirstOrDefault();
            if (datLich.Idmau != null && datLich.Idkh != null && datLich.NgayDat > DateTime.Now)
            {
                model.datLich.Idmau = datLich.Idmau;
                model.datLich.Idkh = datLich.Idkh;
                model.datLich.NgayDat = datLich.NgayDat;
                model.datLich.GhiChu = datLich.GhiChu;

                database.Update(model.datLich);
                await database.SaveChangesAsync();
                return RedirectToAction("BookingList", "Booking");
            }

            return View(model);
        }

        //public ActionResult SelectMau()
        //{
        //    var model = new ViewModel();
        //    model.ListHang = database.Hangs.ToArray();
        //    model.ListMauXe = database.MauXes.ToArray();
        //    return View(model);

        //}
    }
}
