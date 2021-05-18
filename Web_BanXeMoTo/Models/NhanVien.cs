using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class NhanVien
    {
        [Display(Name = "ID Nhân viên")]
        [Required(ErrorMessage = "Không được bỏ trống, không được trùng lặp")]
        public int Idnv { get; set; }
        [Display(Name = "Loại Tài Khoản")]
        public string Idtype { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        public string Pass { get; set; }
        [Display(Name = "Tên nhân viên")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string TenNv { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string DienThoai { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "CMND")]
        public string Cmnd { get; set; }
        [Display(Name = "Avatar")]
        public string Avatar { get; set; }
        [Display(Name = "ID Role")]
        public string Idrole { get; set; }

        public virtual Role IdroleNavigation { get; set; }
        public virtual TypeAcc IdtypeNavigation { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Hãy chọn hình")]
        public IFormFile UpLoadAvt { get; set; }
    }
}
