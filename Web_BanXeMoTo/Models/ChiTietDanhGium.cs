﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class ChiTietDanhGium
    {
        public string Idkh { get; set; }
        public string Idmau { get; set; }
        public string NoiDungDg { get; set; }

        public virtual KhachHang IdkhNavigation { get; set; }
        public virtual MauXe IdmauNavigation { get; set; }
    }
}