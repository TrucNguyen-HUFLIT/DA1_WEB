using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    [Authorize(Roles = "admin, staff")]
    public class HoaDonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public class HoaDonViewModel
    {
        public ChiTietHd ChiTietHd { get; set; }
        public HoaDon HoaDon { get; set; }
        public HoaDon[] ListHoaDon { get; set; }
    }
}
