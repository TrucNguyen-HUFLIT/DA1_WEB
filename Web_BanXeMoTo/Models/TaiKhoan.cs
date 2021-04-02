﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            Admins = new HashSet<Admin>();
            KhachHangs = new HashSet<KhachHang>();
            NhanViens = new HashSet<NhanVien>();
        }

        public string Idtk { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public bool Type { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}