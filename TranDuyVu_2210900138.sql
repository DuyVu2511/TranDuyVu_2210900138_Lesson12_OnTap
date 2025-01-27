USE [TranDuyVu_2210900138]
GO
/****** Object:  Table [dbo].[TDV_SACH]    Script Date: 7/11/2024 3:42:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDV_SACH](
	[Tdv_MaSach] [char](10) NOT NULL,
	[Tdv_TenSach] [nvarchar](50) NULL,
	[Tdv_SoTrang] [int] NULL,
	[Tdv_NamXB] [int] NULL,
	[Tdv_MaTG] [char](10) NULL,
	[Tdv_TrangThai] [bit] NULL,
 CONSTRAINT [PK_TDV_SACH] PRIMARY KEY CLUSTERED 
(
	[Tdv_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TDV_TACGIA]    Script Date: 7/11/2024 3:42:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDV_TACGIA](
	[Tdv_MaTG] [char](10) NOT NULL,
	[Tdv_TenTG] [nvarchar](50) NULL,
 CONSTRAINT [PK_TDV_TACGIA] PRIMARY KEY CLUSTERED 
(
	[Tdv_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TDV_SACH] ([Tdv_MaSach], [Tdv_TenSach], [Tdv_SoTrang], [Tdv_NamXB], [Tdv_MaTG], [Tdv_TrangThai]) VALUES (N'S001      ', N'Tran Duy Vu', 100, 2004, N'2210900138', 1)
INSERT [dbo].[TDV_SACH] ([Tdv_MaSach], [Tdv_TenSach], [Tdv_SoTrang], [Tdv_NamXB], [Tdv_MaTG], [Tdv_TrangThai]) VALUES (N'S002      ', N'Ngot', 88, 2024, N'2210900123', 1)
GO
INSERT [dbo].[TDV_TACGIA] ([Tdv_MaTG], [Tdv_TenTG]) VALUES (N'2210900123', N'Vu Dinh Trong Thang')
INSERT [dbo].[TDV_TACGIA] ([Tdv_MaTG], [Tdv_TenTG]) VALUES (N'2210900138', N'Tran Duy Vu')
GO
ALTER TABLE [dbo].[TDV_SACH]  WITH CHECK ADD  CONSTRAINT [FK_TDV_SACH_TDV_TACGIA] FOREIGN KEY([Tdv_MaTG])
REFERENCES [dbo].[TDV_TACGIA] ([Tdv_MaTG])
GO
ALTER TABLE [dbo].[TDV_SACH] CHECK CONSTRAINT [FK_TDV_SACH_TDV_TACGIA]
GO
