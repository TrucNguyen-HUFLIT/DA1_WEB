using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> Login(LoginMODEL loginModel)
        {
            var model = new LoginViewModel();
            var accountNV = database.NhanViens.Where(x => x.Email == loginModel.Email && x.Pass == loginModel.Password).FirstOrDefault();
            var accountKH = database.KhachHangs.Where(x => x.Email == loginModel.Email && x.Pass == loginModel.Password).FirstOrDefault();
            if (accountNV != null)
            {
                string accountRole = database.TypeAccs.Where(x => x.Idtype == accountNV.Idtype).Select(x => x.Name).FirstOrDefault();
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, loginModel.Email),
                    new Claim(ClaimTypes.Role, accountRole),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                TempData["Role"] = accountRole;

                HttpContext.Session.SetString("email", loginModel.Email);
                return RedirectToAction("Index", "Customer");
            }
            else if (accountKH != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, loginModel.Email),
                    new Claim(ClaimTypes.Role, database.TypeAccs.Where(x=>x.Idtype==accountKH.Idtype).FirstOrDefault().Name),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                HttpContext.Session.SetString("email", loginModel.Email);
                return RedirectToAction("Products", "Products");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
    public class LoginViewModel
    {
        public NhanVien nhanviens;
        public LoginMODEL loginModel;
        public NhanVien[] listNhanVien;
    }
}
