using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class LoginController : Controller
    {
        private readonly QLMoToContext database;

        public LoginController(QLMoToContext db)
        {
            database = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var modelNV = database.NhanViens.Where(x => x.Email == loginModel.Email && x.Pass == loginModel.Password).FirstOrDefault();
            var modelKH = database.KhachHangs.Where(x => x.Email == loginModel.Email && x.Pass == loginModel.Password).FirstOrDefault();
            if (modelNV != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, loginModel.Email),
                    new Claim(ClaimTypes.Role, database.TypeAccs.Where(x=>x.Idtype==modelNV.Idtype).FirstOrDefault().Name),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                HttpContext.Session.SetString("email", loginModel.Email);
                return RedirectToAction("ProfileNhanVien", "Profile");
            }
            else if (modelKH != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, loginModel.Email),
                    new Claim(ClaimTypes.Role, database.TypeAccs.Where(x=>x.Idtype==modelKH.Idtype).FirstOrDefault().Name),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                HttpContext.Session.SetString("email", loginModel.Email);
                return RedirectToAction("Products", "Products");
            }

            ViewBag.error = "Sai thông tin tài khoản";
            return View("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModels)
        {
            if (ModelState.IsValid)
            {
                var emailExisted = database.KhachHangs.Any(x => x.Email == registerModels.Email);
                if(emailExisted)
                {
                    ViewBag.error = "Email đã tồn tại";
                    return View(registerModels);
                }
                var model = new KhachHang
                {
                    Idkh = database.KhachHangs.ToArray()[^1].Idkh + 1,
                    TenKh = registerModels.Email,
                    Email = registerModels.Email,
                    Pass = registerModels.Password,
                    DiaChi = "",
                    DienThoai = "",
                    Avatar = "icon.png",
                    Idtype = "type03",
                };

                database.KhachHangs.Add(model);
                await database.SaveChangesAsync();
                return View("Login");
            }
            return View(registerModels);
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            StaticAcc.Avatar = "";
            StaticAcc.Name = "";
            StaticAcc.IdRole = "";
            HttpContext.Session.Remove("email");
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (StaticAcc.TypeAcc == "customer")
            {
                StaticAcc.TypeAcc = "";
                return RedirectToAction("Products", "Products");
            }
            else
            {
                StaticAcc.TypeAcc = "";
                return RedirectToAction("Login");
            }
        }
    }
}
