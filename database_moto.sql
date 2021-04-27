USE [QLMoTo]
GO
/****** Object:  Table [dbo].[ChiTietDG]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDG](
	[IDKH] [varchar](50) NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[NoiDungDG] [nvarchar](200) NULL,
 CONSTRAINT [PK_ChiTietDanhGia] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC,
	[IDMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[IDHD] [varchar](50) NOT NULL,
	[IDXe] [varchar](50) NOT NULL,
	[KhuyenMai] [int] NULL,
	[GiaBan] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC,
	[IDXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatLich]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatLich](
	[IDDatLich] [varchar](50) NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[IDKH] [varchar](50) NOT NULL,
	[NgayDat] [date] NOT NULL,
	[XacNhan] [bit] NOT NULL,
 CONSTRAINT [PK_DatLich] PRIMARY KEY CLUSTERED 
(
	[IDDatLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hang]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang](
	[IDHang] [varchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_Hang] PRIMARY KEY CLUSTERED 
(
	[IDHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHD] [varchar](50) NOT NULL,
	[IDKH] [varchar](50) NOT NULL,
	[NgayDat] [date] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IDKH] [varchar](50) NOT NULL,
	[IDTK] [varchar](50) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NOT NULL,
	[Avatar] [varchar](max) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[IDKM] [varchar](50) NOT NULL,
	[GiaTri] [int] NOT NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[IDKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MauXe]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MauXe](
	[IDMau] [varchar](50) NOT NULL,
	[IDKM] [varchar](50) NOT NULL,
	[IDHang] [varchar](50) NOT NULL,
	[TenXe] [nvarchar](50) NOT NULL,
	[GiaBan] [money] NOT NULL,
	[HinhAnh1] [varchar](max) NULL,
	[HinhAnh2] [varchar](max) NULL,
	[HinhAnh3] [varchar](max) NULL,
	[BaoHanh] [int] NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_MauXe] PRIMARY KEY CLUSTERED 
(
	[IDMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNV] [varchar](50) NOT NULL,
	[IDTK] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[DienThoai] [varchar](20) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[CMND] [varchar](20) NOT NULL,
	[Avatar] [varchar](max) NULL,
	[IDRole] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[IDRole] [varchar](50) NOT NULL,
	[QLMau] [bit] NOT NULL,
	[QLHang] [bit] NOT NULL,
	[QLGia] [bit] NOT NULL,
	[QLHD] [bit] NOT NULL,
	[QLNV] [bit] NOT NULL,
	[QLBanHang] [bit] NOT NULL,
	[QLDatLich] [bit] NOT NULL,
	[DSXe] [bit] NOT NULL,
	[DSKH] [bit] NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[IDRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[IDTK] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[Type] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[IDTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 4/27/2021 1:57:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[IDXe] [varchar](50) NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[TenXe] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[IDXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[DatLich] ([IDDatLich], [IDMau], [IDKH], [NgayDat], [XacNhan]) VALUES (N'DL1', N'BMW-HP4', N'kh01', CAST(N'2021-04-20' AS Date), 1)
GO
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'1', N'a', NULL)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'BMW', N'BMW', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'DCT', N'Ducati', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'HD', N'Honda', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'KTM', N'KTM', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'KW', N'Kawasaki', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'SZ', N'Suzuki', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'YM', N'Yamaha', 1)
GO
INSERT [dbo].[KhachHang] ([IDKH], [IDTK], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (N'kh01', N'tk01', N'nam', N'abc', N'123', N'123')
GO
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM0', 0)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM10', 10)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM100', 100)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM15', 15)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM20', 20)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM25', 25)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM30', 30)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM35', 35)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM40', 40)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM45', 45)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM50', 50)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM55', 55)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM60', 60)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM65', 65)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM70', 70)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM75', 75)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM80', 80)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM85', 85)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM90', 90)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM95', 95)
GO
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'1', N'KM70', N'BMW', N'DemoEdit', 60000000.0000, N'ADVENTURE_02.png', N'ADVENTURE_02.png', N'ADVENTURE_02.png', 5, N'i8', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW-HP4', N'KM0', N'BMW', N'BMW HP4', 1100000000.0000, N'hp41.jpg', N'hp41.jpg', N'hp41.jpg', 2, N'đây là mô tả', NULL)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW01', N'KM0', N'BMW', N'S1000RR', 949000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'BMW S1000RR', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW02', N'KM0', N'BMW', N'R9T-RACER', 659000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'BMW R9T Racer 719', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW03', N'KM0', N'BMW', N'R1200-GSA', 659000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'BMW R1200 GSA', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT01', N'KM0', N'DCT', N'SUPER-SPORT', 570900000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Ducati Super Sport', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT02', N'KM0', N'DCT', N'MONSTER-1200S', 800000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Ducati Monster 1200S', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT03', N'KM0', N'DCT', N'MULTISTRADA-1260S', 743000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Ducati Multistrada 1260S', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD01', N'KM0', N'HD', N'CBR-1000RR', 560000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Honda CBR1000RR', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD02', N'KM0', N'HD', N'CB1000R', 468000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Honda CB1000R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD03', N'KM0', N'HD', N'REBEL-500', 180000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Honda Rebel 500', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM01', N'KM0', N'KTM', N'SUPER-DUKE', 690000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'KTM Super Duke 1290', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM02', N'KM0', N'KTM', N'SUPER-ADVENTURE', 690000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'KTM Super Adventure 1290', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM03', N'KM0', N'KTM', N'RC8-R', 590000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'KTM 1190 RC8R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW01', N'KM0', N'KW', N'H2-SX', 899000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Kawasaki H2 SX', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW02', N'KM0', N'KW', N'VERSYS-1000', 419000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Kawasaki Versys 1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW03', N'KM0', N'KW', N'Z-1000R', 459000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Kawasaki Z1000R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ01', N'KM0', N'SZ', N'GSX-S1000', 402000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Suzuki GSX-S1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ02', N'KM0', N'SZ', N'GSX-R1000', 436000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Suzuki GSX-R1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ03', N'KM0', N'SZ', N'V-STROM1000', 369000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Suzuki V-STROM 1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM01', N'KM0', N'YM', N'MT-10', 557000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Yamaha MT-10', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM02', N'KM0', N'YM', N'XSR900', 320000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Yamaha XSR900', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM03', N'KM0', N'YM', N'XZF-R1', 729000000.0000, N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', N'BMW-S1000RR.jpg', 12, N'Yamaha XZF-R1', 1)
GO
INSERT [dbo].[NhanVien] ([IDNV], [IDTK], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar], [IDRole]) VALUES (N'nv01', N'tk03', N'Ngoc Truc', N'0335488465', N'Địa chỉ', N'CMND', N'avt-kh1.jpg', N'role01')
GO
INSERT [dbo].[Role] ([IDRole], [QLMau], [QLHang], [QLGia], [QLHD], [QLNV], [QLBanHang], [QLDatLich], [DSXe], [DSKH]) VALUES (N'role01', 1, 1, 1, 1, 1, 1, 1, 1, 1)
GO
INSERT [dbo].[TaiKhoan] ([IDTK], [Email], [Pass], [Type]) VALUES (N'tk01', N'nam.darkstar@gmail.com', N'abc', 1)
INSERT [dbo].[TaiKhoan] ([IDTK], [Email], [Pass], [Type]) VALUES (N'tk02', N'nv.huflit@gmail.com', N'nv', 1)
INSERT [dbo].[TaiKhoan] ([IDTK], [Email], [Pass], [Type]) VALUES (N'tk03', N'ad.huflit@gmail.com', N'admin', 1)
GO
ALTER TABLE [dbo].[ChiTietDG]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDG_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([IDKH])
GO
ALTER TABLE [dbo].[ChiTietDG] CHECK CONSTRAINT [FK_ChiTietDG_KhachHang]
GO
ALTER TABLE [dbo].[ChiTietDG]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDG_MauXe] FOREIGN KEY([IDMau])
REFERENCES [dbo].[MauXe] ([IDMau])
GO
ALTER TABLE [dbo].[ChiTietDG] CHECK CONSTRAINT [FK_ChiTietDG_MauXe]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_HoaDon] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HoaDon] ([IDHD])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_Xe] FOREIGN KEY([IDXe])
REFERENCES [dbo].[Xe] ([IDXe])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_Xe]
GO
ALTER TABLE [dbo].[DatLich]  WITH CHECK ADD  CONSTRAINT [FK_DatLich_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([IDKH])
GO
ALTER TABLE [dbo].[DatLich] CHECK CONSTRAINT [FK_DatLich_KhachHang]
GO
ALTER TABLE [dbo].[DatLich]  WITH CHECK ADD  CONSTRAINT [FK_DatLich_MauXe] FOREIGN KEY([IDMau])
REFERENCES [dbo].[MauXe] ([IDMau])
GO
ALTER TABLE [dbo].[DatLich] CHECK CONSTRAINT [FK_DatLich_MauXe]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([IDKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_TaiKhoan] FOREIGN KEY([IDTK])
REFERENCES [dbo].[TaiKhoan] ([IDTK])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_TaiKhoan]
GO
ALTER TABLE [dbo].[MauXe]  WITH CHECK ADD  CONSTRAINT [FK_MauXe_Hang] FOREIGN KEY([IDHang])
REFERENCES [dbo].[Hang] ([IDHang])
GO
ALTER TABLE [dbo].[MauXe] CHECK CONSTRAINT [FK_MauXe_Hang]
GO
ALTER TABLE [dbo].[MauXe]  WITH CHECK ADD  CONSTRAINT [FK_MauXe_KhuyenMai] FOREIGN KEY([IDKM])
REFERENCES [dbo].[KhuyenMai] ([IDKM])
GO
ALTER TABLE [dbo].[MauXe] CHECK CONSTRAINT [FK_MauXe_KhuyenMai]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhanVien] FOREIGN KEY([IDRole])
REFERENCES [dbo].[Role] ([IDRole])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([IDTK])
REFERENCES [dbo].[TaiKhoan] ([IDTK])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_MauXe] FOREIGN KEY([IDMau])
REFERENCES [dbo].[MauXe] ([IDMau])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_MauXe]
GO
