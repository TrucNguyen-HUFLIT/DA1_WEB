using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly QLMoToContext database;
        private readonly IWebHostEnvironment hostEnvironment;

        public ProductsController(QLMoToContext db)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Products()
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            return View(model);

            //List<MauXe> maulist = database.MauXes.ToList();
            //List<Hang> hanglist = database.Hangs.ToList();
            //var query = from hang in hanglist
            //            join mau in maulist on hang.Idhang equals mau.Idhang into tbl
            //            select new ViewModel
            //            {
            //                TenHang = hang.TenHang,
            //                ListMauXe = (MauXe[])(from p in tbl 
            //                          select p)
            //            };
            //return View(query.ToList());
        }

        public IActionResult ProductsDetail(string id)
        {
            return View(database.MauXes.Where(model => model.Idmau == id).FirstOrDefault());
        }

        public ActionResult Query_Mau_Hang()
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            return View(model);

            //List<MauXe> maulist = database.MauXes.ToList();
            //List<Hang> hanglist = database.Hangs.ToList();
            //var query = from hang in hanglist
            //            join mau in maulist on hang.Idhang equals mau.Idhang into tbl
            //            select new ViewModel
            //            {
            //                TenHang = hang.TenHang,
            //                ListMau = from p in tbl
            //                          select p
            //            };
            //return View(query.ToList());
        }
        public ActionResult Query_Hang(string id)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.Where(x => x.Idhang == id).ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            //model.mauXe = database.MauXes.Where(x => x.Idhang == id).FirstOrDefault();            
            return View(model);

            //var a = database.MauXes.Where(s => s.Idhang.Contains(id));
            //return View(a);
        }

        //public class ViewModel
        //{
        //    //Create Model to use Multiple Model in View
        //    public Hang hang { get; set; }
        //    public string TenHang { get; set; }
        //    public MauXe mauXe { get; set; }
        //    public MauXe[] ListMauXe { get; set; }
        //    public Hang[] ListHang { get; set; }
        //}
        public IActionResult Query_Gia(double min = double.MinValue, double max = double.MaxValue)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.Where(p => (double)p.GiaBan >= min && (double)p.GiaBan <= max).ToArray();
            return View(model);

            //var list = database.MauXes.Where(p => (double)p.GiaBan >= min && (double)p.GiaBan <= max).ToArray();
            //return View(list);
        }
    }
}
