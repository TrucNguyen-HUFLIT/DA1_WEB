using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_BanXeMoTo.Models;

namespace Web_BanXeMoTo.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly QLMoToContext database;
        private readonly IWebHostEnvironment hostEnvironment;

        public NhanVienController(QLMoToContext db, IWebHostEnvironment hostEnvironment)
        {
            database = db;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var model = new ViewModelNV();
            model.ListNhanVien = database.NhanViens.ToArray();
            model.ListTaiKhoan = database.TaiKhoans.ToArray();
            return View(model);
        }

        public IActionResult Detail(string id)
        {
            var model = new ViewModelNV();
            model.nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault();
            model.ListNhanVien = database.NhanViens.ToArray();
            model.ListTaiKhoan = database.TaiKhoans.ToArray();
            return View(model);
        }
        public IActionResult Create()
        {
            var model = new ViewModelNV();
            model.tknv = new TaiKhoanNVModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaiKhoanNVModel tknv)
        {

            var modelnv = new ViewModelNV();
            if (ModelState.IsValid)
            {

                TaiKhoan tk = new TaiKhoan();
                NhanVien nv = new NhanVien();
                string wwwRootPath = hostEnvironment.WebRootPath;
                string fileName1 = Path.GetFileNameWithoutExtension(tknv.UpLoadAvt.FileName);
                string extension1 = Path.GetExtension(tknv.UpLoadAvt.FileName);
                tknv.Avatar = fileName1 += extension1;
                string path1 = Path.Combine(wwwRootPath + "/img/", fileName1);
                using (var fileStream = new FileStream(path1, FileMode.Create))
                {
                    await tknv.UpLoadAvt.CopyToAsync(fileStream);
                }
                tk.Idtk = tknv.Idtk;
                tk.Email = tknv.Email;
                tk.Pass = tknv.Pass;
                tk.Type = tknv.Type;
                nv.Idtk = tknv.Idtk;
                nv.Idnv = tknv.Idnv;
                nv.TenNv = tknv.TenNv;
                nv.DienThoai = tknv.DienThoai;
                nv.DiaChi = tknv.DiaChi;
                nv.Cmnd = tknv.Cmnd;
                nv.Avatar = tknv.Avatar;
                nv.UpLoadAvt = tknv.UpLoadAvt;
                this.database.Add(tk);
                this.database.Add(nv);
                await this.database.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View(modelnv);
        }
        public IActionResult Edit(string id)
        {
            var model = new ViewModelNV();

            model.tknv = new TaiKhoanNVModel();
            model.nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault();

            model.taiKhoan = database.TaiKhoans.Where(x => x.Idtk == model.nhanVien.Idtk).FirstOrDefault();
            model.tknv.Idnv = model.nhanVien.Idnv;
            model.tknv.Idtk = model.taiKhoan.Idtk;
            model.tknv.TenNv = model.nhanVien.TenNv;
            model.tknv.DienThoai = model.nhanVien.DienThoai;
            model.tknv.DiaChi = model.nhanVien.DiaChi;
            model.tknv.Cmnd = model.nhanVien.Cmnd;
            model.tknv.Email = model.taiKhoan.Email;
            model.tknv.Pass = model.taiKhoan.Pass;
            model.tknv.Type = model.taiKhoan.Type;
            model.tknv.Avatar = model.nhanVien.Avatar;
            model.tknv.UpLoadAvt = model.nhanVien.UpLoadAvt;
            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, NhanVien nhanVien)
        {
            var model = new ViewModelNV();
            model.tknv = new TaiKhoanNVModel();
            model.nhanVien = nhanVien = database.NhanViens.Where(x => x.Idnv == id).FirstOrDefault();
            return View(model);
            string wwwRootPath = hostEnvironment.WebRootPath;
            string fileName1;
            string extension1;
            if (nhanVien.UpLoadAvt == null)
            {
                fileName1 = Path.GetFileNameWithoutExtension(model.nhanVien.Avatar);
                extension1 = Path.GetExtension(model.nhanVien.Avatar);
                nhanVien.Avatar = fileName1 += extension1;
            }
            else
            {
                fileName1 = Path.GetFileNameWithoutExtension(nhanVien.UpLoadAvt.FileName);
                extension1 = Path.GetExtension(nhanVien.UpLoadAvt.FileName);
                nhanVien.Avatar = fileName1 += extension1;
                string path1 = Path.Combine(wwwRootPath + "/img/", fileName1);
                using (var fileStream = new FileStream(path1, FileMode.Create))
                {
                    await nhanVien.UpLoadAvt.CopyToAsync(fileStream);
                }
            }
            database.Update(model.nhanVien);
            await database.SaveChangesAsync();
            return RedirectToAction("Index", "NhanVien");
        }

    }

    public class ViewModelNV
    {
        public TaiKhoanNVModel tknv { get; set; }
        public NhanVien nhanVien { get; set; }
        public TaiKhoan taiKhoan { get; set; }
        public NhanVien[] ListNhanVien { get; set; }
        public TaiKhoan[] ListTaiKhoan { get; set; }
    }

}
