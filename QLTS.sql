USE [QLTS]

/****** Object:  UserDefinedFunction [dbo].[AUTO_IDTK]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[AUTO_IDTK]()
RETURNS VarChar(5)
AS
BEGIN
	DECLARE @ID varchar(5)
	IF (SELECT COUNT(ID) FROM tbTaiKhoan) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(ID, 3)) FROM tbTaiKhoan
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'ID00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'ID0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  Table [dbo].[tbCT_HDNhap]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCT_HDNhap](
	[MaHDNhap] [char](10) NOT NULL,
	[MaNL] [char](10) NOT NULL,
	[DonGia] [money] NULL,
	[SoLuongNhap] [int] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_CT_HDNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCT_HoaDonBH]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCT_HoaDonBH](
	[MaHD] [char](20) NOT NULL,
	[MaMon] [char](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DVT] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
	[ChietKhau] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CT_HoaDonBH] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbChamCong]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChamCong](
	[MaChamCong] [char](10) NOT NULL,
	[NgayViPham] [datetime] NULL,
	[MaNVVP] [char](10) NULL,
	[maViPham] [char](10) NULL,
	[SoLuongLoi] [int] NULL,
	[SoNgayLam] [int] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED 
(
	[MaChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbChucVu]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChucVu](
	[MaCV] [char](10) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_PhanCong] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbGiamGia]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbGiamGia](
	[id] [char](10) NOT NULL,
	[MaGiamGia] [char](10) NULL,
	[MaKH] [char](10) NULL,
	[MaMon] [char](10) NULL,
	[ThoiHan] [datetime] NULL,
	[discount] [float] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_tbGiamGia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbHoaDonBH]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHoaDonBH](
	[MaHD] [char](20) NOT NULL,
	[NgayLapHD] [datetime] NULL,
	[MaKH] [char](10) NULL,
	[MaNV] [char](10) NULL,
	[TongTien] [float] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_HoaDonBH] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbHoaDonNhap]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbHoaDonNhap](
	[MaHDNhap] [char](10) NOT NULL,
	[NgayLapHD] [datetime] NULL,
	[MaNVLap] [char](10) NULL,
	[NgayNhan] [datetime] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbKhachHang]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbKhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[SDT] [char](10) NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbLoaiMon]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLoaiMon](
	[MaLoaiMon] [char](10) NOT NULL,
	[TenLoaiMon] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_LoaiMon] PRIMARY KEY CLUSTERED 
(
	[MaLoaiMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbMon]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMon](
	[MaMon] [char](10) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[LoaiMon] [char](10) NULL,
	[DonGia] [float] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[DonVi] [nvarchar](50) NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_Mon] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbNguyenLieu]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbNguyenLieu](
	[MaNL] [char](10) NOT NULL,
	[TenNL] [nvarchar](50) NULL,
	[MaNCC] [char](10) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[SoLuongHienCo] [int] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbNhaCungCap]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbNhaCungCap](
	[MaNCC] [char](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbNhanVien]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbNhanVien](
	[MaNV] [char](10) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[NgSinh] [datetime] NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[Luong] [float] NULL,
	[MaChucVu] [char](10) NULL,
	[HinhAnh] [varchar](30) NULL,
	[DaXoa] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTaiKhoan]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTaiKhoan](
	[ID] [char](5) NOT NULL,
	[Username] [char](10) NOT NULL,
	[Pass] [varchar](30) NULL,
	[ChucVu] [char](10) NULL,
 CONSTRAINT [PK__tbTaiKho__3214EC2777B75E5B] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViPham]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViPham](
	[maViPham] [char](10) NOT NULL,
	[noiDungViPham] [nvarchar](50) NULL,
	[tienTruLuong] [money] NULL,
 CONSTRAINT [PK_ViPham] PRIMARY KEY CLUSTERED 
(
	[maViPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_HoaDonBH]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_HoaDonBH]
AS
SELECT  dbo.tbMon.TenMon, dbo.tbCT_HoaDonBH.SoLuong, dbo.tbHoaDonBH.NgayLapHD, dbo.tbHoaDonBH.MaHD, dbo.tbHoaDonBH.MaKH, dbo.tbHoaDonBH.MaNV, dbo.tbHoaDonBH.TongTien, dbo.tbCT_HoaDonBH.MaMon, dbo.tbCT_HoaDonBH.DVT, 
                 dbo.tbCT_HoaDonBH.DonGia, dbo.tbCT_HoaDonBH.ChietKhau, dbo.tbCT_HoaDonBH.ThanhTien
FROM      dbo.tbMon INNER JOIN
                 dbo.tbCT_HoaDonBH ON dbo.tbMon.MaMon = dbo.tbCT_HoaDonBH.MaMon INNER JOIN
                 dbo.tbHoaDonBH ON dbo.tbCT_HoaDonBH.MaHD = dbo.tbHoaDonBH.MaHD
GO
/****** Object:  View [dbo].[View_TongTienHD]    Script Date: 2022-07-13 22:57:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_TongTienHD]
AS
SELECT  SUM(TongTien) AS TongTienHD
FROM      dbo.tbHoaDonBH
GO
ALTER TABLE [dbo].[tbTaiKhoan] ADD  CONSTRAINT [IDTK]  DEFAULT ([DBO].[AUTO_IDTK]()) FOR [ID]
GO
ALTER TABLE [dbo].[tbCT_HDNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_HDNhap_HoaDonNhap] FOREIGN KEY([MaHDNhap])
REFERENCES [dbo].[tbHoaDonNhap] ([MaHDNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbCT_HDNhap] CHECK CONSTRAINT [FK_CT_HDNhap_HoaDonNhap]
GO
ALTER TABLE [dbo].[tbCT_HDNhap]  WITH CHECK ADD  CONSTRAINT [FK_CT_HDNhap_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[tbNguyenLieu] ([MaNL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbCT_HDNhap] CHECK CONSTRAINT [FK_CT_HDNhap_NguyenLieu]
GO
ALTER TABLE [dbo].[tbCT_HoaDonBH]  WITH CHECK ADD  CONSTRAINT [FK_CT_HoaDonBH_HoaDonBH] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tbHoaDonBH] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbCT_HoaDonBH] CHECK CONSTRAINT [FK_CT_HoaDonBH_HoaDonBH]
GO
ALTER TABLE [dbo].[tbCT_HoaDonBH]  WITH CHECK ADD  CONSTRAINT [FK_CT_HoaDonBH_Mon] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tbMon] ([MaMon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbCT_HoaDonBH] CHECK CONSTRAINT [FK_CT_HoaDonBH_Mon]
GO
ALTER TABLE [dbo].[tbChamCong]  WITH CHECK ADD  CONSTRAINT [FK_ChamCong_NhanVien1] FOREIGN KEY([MaNVVP])
REFERENCES [dbo].[tbNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbChamCong] CHECK CONSTRAINT [FK_ChamCong_NhanVien1]
GO
ALTER TABLE [dbo].[tbChamCong]  WITH CHECK ADD  CONSTRAINT [FK_tbChamCong_ViPham] FOREIGN KEY([maViPham])
REFERENCES [dbo].[ViPham] ([maViPham])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbChamCong] CHECK CONSTRAINT [FK_tbChamCong_ViPham]
GO
ALTER TABLE [dbo].[tbGiamGia]  WITH CHECK ADD  CONSTRAINT [FK_tbGiamGia_tbKhachHang1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tbKhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbGiamGia] CHECK CONSTRAINT [FK_tbGiamGia_tbKhachHang1]
GO
ALTER TABLE [dbo].[tbGiamGia]  WITH CHECK ADD  CONSTRAINT [FK_tbGiamGia_tbMon] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tbMon] ([MaMon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbGiamGia] CHECK CONSTRAINT [FK_tbGiamGia_tbMon]
GO
ALTER TABLE [dbo].[tbHoaDonBH]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBH_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tbNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tbHoaDonBH] CHECK CONSTRAINT [FK_HoaDonBH_NhanVien]
GO
ALTER TABLE [dbo].[tbHoaDonBH]  WITH CHECK ADD  CONSTRAINT [FK_tbHoaDonBH_tbKhachHang1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tbKhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbHoaDonBH] CHECK CONSTRAINT [FK_tbHoaDonBH_tbKhachHang1]
GO
ALTER TABLE [dbo].[tbHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhanVien] FOREIGN KEY([MaNVLap])
REFERENCES [dbo].[tbNhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbHoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhanVien]
GO
ALTER TABLE [dbo].[tbMon]  WITH CHECK ADD  CONSTRAINT [FK_Mon_LoaiMon] FOREIGN KEY([LoaiMon])
REFERENCES [dbo].[tbLoaiMon] ([MaLoaiMon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbMon] CHECK CONSTRAINT [FK_Mon_LoaiMon]
GO
ALTER TABLE [dbo].[tbNguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tbNhaCungCap] ([MaNCC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbNguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_NhaCungCap]
GO
ALTER TABLE [dbo].[tbNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tbNhanVien_tbChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[tbChucVu] ([MaCV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbNhanVien] CHECK CONSTRAINT [FK_tbNhanVien_tbChucVu]
GO
ALTER TABLE [dbo].[tbTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tbTaiKhoan_tbNhanVien] FOREIGN KEY([Username])
REFERENCES [dbo].[tbNhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbTaiKhoan] CHECK CONSTRAINT [FK_tbTaiKhoan_tbNhanVien]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[6] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbMon"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbCT_HoaDonBH"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 206
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "tbHoaDonBH"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 206
               Right = 837
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_HoaDonBH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_HoaDonBH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbHoaDonBH"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_TongTienHD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_TongTienHD'
GO
USE [master]
GO
ALTER DATABASE [QLTS] SET  READ_WRITE 
GO
