using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;
using System.Security.Claims;

namespace Web_BanXeMoTo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly QLMoToContext database;
        private readonly IWebHostEnvironment hostEnvironment;

        public ProductsController(QLMoToContext db)
        {
            database = db;
        }
        public IActionResult Products()
        {

             if (User.FindFirst(ClaimTypes.Email)== null)
            {
                var model = new ViewModelKH();
                model.ListHang = database.Hangs.ToArray();
                model.ListMauXe = database.MauXes.ToArray();
                return View(model);
            }
            else
            {
                var email = User.FindFirst(ClaimTypes.Email).Value;
                var model = new ViewModelKH();
                if (email != null)
                {
                    model.ListHang = database.Hangs.ToArray();
                    model.ListMauXe = database.MauXes.ToArray();
                    model.khachHang = database.KhachHangs.Where(x => x.Email == email).FirstOrDefault();
                    model.ListType = database.TypeAccs.ToArray();

                    StaticAcc.Avatar = model.khachHang.Avatar;
                    StaticAcc.Name = model.khachHang.TenKh; 
                    StaticAcc.TypeAcc = database.TypeAccs.Where(x => x.Idtype == model.khachHang.Idtype).Select(x => x.Name).FirstOrDefault();
                }
                return View(model);
            }
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
        }
        public ActionResult Query_Hang(string id)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.Where(x => x.Idhang == id).ToArray();
            model.ListMauXe = database.MauXes.ToArray();
            return View(model);
        }

        public IActionResult Query_Gia(double min = double.MinValue, double max = double.MaxValue)
        {
            var model = new ViewModel();
            model.ListHang = database.Hangs.ToArray();
            model.ListMauXe = database.MauXes.Where(p => (double)p.GiaBan >= min && (double)p.GiaBan <= max).ToArray();
            return View(model);

        }
    }
}
