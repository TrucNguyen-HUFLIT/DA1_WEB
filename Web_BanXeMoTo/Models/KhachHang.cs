using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            ChiTietDgs = new HashSet<ChiTietDg>();
            DatLiches = new HashSet<DatLich>();
            HoaDons = new HashSet<HoaDon>();
        }
        [Display(Name = "ID")]
        public string Idkh { get; set; }
        [Display(Name = "Loại Tài Khoản")]
        public string Idtype { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        public string Pass { get; set; }
        [Display(Name = "Tên Khách Hàng")]
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Avatar { get; set; }

        public virtual TypeAcc IdtypeNavigation { get; set; }
        public virtual ICollection<ChiTietDg> ChiTietDgs { get; set; }
        public virtual ICollection<DatLich> DatLiches { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        [NotMapped]
        public IEnumerable<LoaiKh> ListLoaiKh { get; set; }
    }
}
