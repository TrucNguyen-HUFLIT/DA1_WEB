using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class Admin
    {
        public string Idad { get; set; }
        public string Idtk { get; set; }
        public string TenAd { get; set; }
        public string DiaChi { get; set; }
        public int DienThoai { get; set; }
        public int? Cmnd { get; set; }

        public virtual TaiKhoan IdtkNavigation { get; set; }
    }
}
