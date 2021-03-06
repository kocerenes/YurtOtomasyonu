USE [master]
GO
/****** Object:  Database [YurtOtomasyon]    Script Date: 2.05.2021 16:21:39 ******/
CREATE DATABASE [YurtOtomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YurtOtomasyon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\YurtOtomasyon.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'YurtOtomasyon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\YurtOtomasyon_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [YurtOtomasyon] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YurtOtomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YurtOtomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YurtOtomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YurtOtomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YurtOtomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YurtOtomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [YurtOtomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [YurtOtomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YurtOtomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YurtOtomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YurtOtomasyon] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [YurtOtomasyon]
GO
/****** Object:  Table [dbo].[Tbl_Bolum]    Script Date: 2.05.2021 16:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Bolum](
	[BolumId] [tinyint] IDENTITY(1,1) NOT NULL,
	[BolumAd] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Borclar]    Script Date: 2.05.2021 16:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Borclar](
	[OgrId] [int] NULL,
	[OgrAd] [varchar](20) NULL,
	[OgrSoyad] [varchar](20) NULL,
	[OgrKalanBorc] [smallint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Giderler]    Script Date: 2.05.2021 16:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Giderler](
	[GiderId] [tinyint] IDENTITY(1,1) NOT NULL,
	[Elektrik] [smallint] NULL,
	[Su] [int] NULL,
	[Dogalgaz] [int] NULL,
	[Internet] [int] NULL,
	[Gida] [int] NULL,
	[Personel] [int] NULL,
	[Diger] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Kasa]    Script Date: 2.05.2021 16:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Kasa](
	[OgrId] [smallint] NULL,
	[OdemeAy] [varchar](20) NULL,
	[OdemeMiktar] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Oda]    Script Date: 2.05.2021 16:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Oda](
	[OdaId] [tinyint] IDENTITY(1,1) NOT NULL,
	[OdaNo] [char](3) NULL,
	[OdaKapasite] [char](1) NULL,
	[OdaAktif] [char](1) NULL,
	[OdaDurum] [bit] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Ogrenci]    Script Date: 2.05.2021 16:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Ogrenci](
	[OgrId] [int] IDENTITY(1,1) NOT NULL,
	[OgrAd] [varchar](20) NULL,
	[OgrSoyad] [varchar](20) NULL,
	[OgrTc] [char](11) NULL,
	[OgrTelefon] [varchar](20) NULL,
	[OgrDogum] [varchar](12) NULL,
	[OgrBolum] [varchar](30) NULL,
	[OgrMail] [varchar](50) NULL,
	[OgrOdaNo] [char](3) NULL,
	[OgrVeliAdSoyad] [varchar](50) NULL,
	[OgrVeliTelefon] [varchar](20) NULL,
	[OgrVeliAdres] [varchar](200) NULL,
 CONSTRAINT [PK_Tbl_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OgrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Personel]    Script Date: 2.05.2021 16:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Personel](
	[PersonelId] [tinyint] IDENTITY(1,1) NOT NULL,
	[PersonelAdSoyad] [varchar](50) NULL,
	[PersonelDepartman] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Yonetici]    Script Date: 2.05.2021 16:21:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Yonetici](
	[YoneticiId] [tinyint] IDENTITY(1,1) NOT NULL,
	[YoneticiAd] [varchar](20) NULL,
	[YoneticiSifre] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Bolum] ON 

INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (1, N'Bilgisayar Mühendisi')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (2, N'Elektrik Mühendisliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (3, N'Otomotiv Mühendisliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (4, N'Yazılım Mühendisliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (5, N'Endüstri Mühendisliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (6, N'Mekatronik Mühendisliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (7, N'Edebiyat')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (8, N'Sosyal Bilimler')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (9, N'Tıp')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (10, N'Diş Hekimliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (11, N'Veteriner Hekimliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (12, N'Biyoloji Mühendisliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (13, N'Muhasebe')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (14, N'işletme')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (15, N'Su ürünleri')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (16, N'Coğrafya')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (17, N'Bilgisayar Öğretmenliği')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (18, N'Konservatuar')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (19, N'Uluslararası İlişkiler')
INSERT [dbo].[Tbl_Bolum] ([BolumId], [BolumAd]) VALUES (22, N'Sınıf Öğretmenliği')
SET IDENTITY_INSERT [dbo].[Tbl_Bolum] OFF
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (1, N'Hakan', N'Demir', 2700)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (2, N'Hasan', N'Özgür', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (3, N'Enes', N'Koçer', 2100)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (4, N'Mustafa', N'Aktaş', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (5, N'Ali', N'Çınar', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (6, N'asda,', N'', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (7, N'asdasd', N'asdsad', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (8, N'asdasd', N'', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (9, N'asdasdsad', N'ad', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (1, N'asdasd', N'sadasdsad', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (2, N'asdasd', N'dasdasd', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (3, N'asdasd', N'asdasdas', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (4, N'asdsad', N'sadasdasda', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (5, N'asdasd', N'asdasdasd', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (6, N'assdasd', N'dasdasd', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (7, N'aasdad', N'asdasd', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (8, N'safsafas', N'fsasafasf', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (9, N'asdasdsad', N'dasdsadad', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (10, N'asdasdsad', N'DSAADSAD', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (11, N'Enes', N'Koçer', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (1, N'Enes', N'Koçer', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (2, N'Yusuf', N'Erdoğan', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (3, N'Murat', N'Tütüncü', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (4, N'jasd ', N' jh nıj', 3000)
INSERT [dbo].[Tbl_Borclar] ([OgrId], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (5, N'asdasdasd', N'asdasdsadsad', 3000)
SET IDENTITY_INSERT [dbo].[Tbl_Giderler] ON 

INSERT [dbo].[Tbl_Giderler] ([GiderId], [Elektrik], [Su], [Dogalgaz], [Internet], [Gida], [Personel], [Diger]) VALUES (1, 3000, 1600, 2400, 280, 7500, 16000, 5400)
SET IDENTITY_INSERT [dbo].[Tbl_Giderler] OFF
INSERT [dbo].[Tbl_Kasa] ([OgrId], [OdemeAy], [OdemeMiktar]) VALUES (2, N'Haziran', 300)
INSERT [dbo].[Tbl_Kasa] ([OgrId], [OdemeAy], [OdemeMiktar]) VALUES (1, N'Haziran', 550)
INSERT [dbo].[Tbl_Kasa] ([OgrId], [OdemeAy], [OdemeMiktar]) VALUES (1, N'Mayıs', 700)
INSERT [dbo].[Tbl_Kasa] ([OgrId], [OdemeAy], [OdemeMiktar]) VALUES (3, N'Mayıs', 320)
INSERT [dbo].[Tbl_Kasa] ([OgrId], [OdemeAy], [OdemeMiktar]) VALUES (1, N'Ocak', 1000)
INSERT [dbo].[Tbl_Kasa] ([OgrId], [OdemeAy], [OdemeMiktar]) VALUES (3, N'Ocak', 900)
SET IDENTITY_INSERT [dbo].[Tbl_Oda] ON 

INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (1, N'101', N'1', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (2, N'102', N'1', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (3, N'103', N'1', N'2', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (4, N'104', N'1', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (5, N'105', N'1', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (6, N'201', N'2', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (7, N'202', N'2', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (8, N'203', N'2', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (9, N'204', N'2', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (10, N'205', N'2', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (11, N'301', N'3', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (12, N'302', N'3', N'1', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (13, N'303', N'3', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (14, N'304', N'3', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (15, N'305', N'3', N'1', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (16, N'401', N'4', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (17, N'402', N'4', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (18, N'403', N'4', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (19, N'404', N'4', N'0', 1)
INSERT [dbo].[Tbl_Oda] ([OdaId], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (20, N'405', N'4', N'0', 1)
SET IDENTITY_INSERT [dbo].[Tbl_Oda] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Ogrenci] ON 

INSERT [dbo].[Tbl_Ogrenci] ([OgrId], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (2, N'Yusuf', N'Erdoğan', N'41782364182', N'(532) 545-1251', N'12.02.2000', N'Sosyal Bilimler', N'yusuf@gmail.com', N'305', N'Mustafa Erdoğan', N'(532) 475-9120', N'ıashdnıausdnhasjhdbjadsbds bas bdasdb absd')
INSERT [dbo].[Tbl_Ogrenci] ([OgrId], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (3, N'Murat', N'Tütüncü', N'75182638912', N'(541) 287-4192', N'13.09.1997', N'Sınıf Öğretmenliği', N'murat123@gmail.com', N'302', N'Arda Tütüncü', N'(541) 238-9719', N'ojaısnjb ahjusbd uhjab habsd habd ')
INSERT [dbo].[Tbl_Ogrenci] ([OgrId], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (4, N'jasd ', N' jh nıj', N'78689767697', N'(417) 863-4128', N'12.03.2000', N'Edebiyat', N'ajsdoıa j@gmail.com', N'103', N'dasdadsasd', N'(213) 123-1231', N'asdasdasdasdasd')
INSERT [dbo].[Tbl_Ogrenci] ([OgrId], [OgrAd], [OgrSoyad], [OgrTc], [OgrTelefon], [OgrDogum], [OgrBolum], [OgrMail], [OgrOdaNo], [OgrVeliAdSoyad], [OgrVeliTelefon], [OgrVeliAdres]) VALUES (5, N'asdasdasd', N'asdasdsadsad', N'12312312312', N'(441) 231-4123', N'12.02.2002', N'Sosyal Bilimler', N'asdasdasdasd', N'103', N'asdasdasd ', N'(123) 213-2131', N'asdasdasd da d asd asd ')
SET IDENTITY_INSERT [dbo].[Tbl_Ogrenci] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Personel] ON 

INSERT [dbo].[Tbl_Personel] ([PersonelId], [PersonelAdSoyad], [PersonelDepartman]) VALUES (1, N'Murat Altındağ', N'Müdür yardımcısı')
SET IDENTITY_INSERT [dbo].[Tbl_Personel] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Yonetici] ON 

INSERT [dbo].[Tbl_Yonetici] ([YoneticiId], [YoneticiAd], [YoneticiSifre]) VALUES (1, N'admin', N'12345')
INSERT [dbo].[Tbl_Yonetici] ([YoneticiId], [YoneticiAd], [YoneticiSifre]) VALUES (2, N'admin41', N'4141')
INSERT [dbo].[Tbl_Yonetici] ([YoneticiId], [YoneticiAd], [YoneticiSifre]) VALUES (3, N'enes', N'4144')
INSERT [dbo].[Tbl_Yonetici] ([YoneticiId], [YoneticiAd], [YoneticiSifre]) VALUES (5, N'mehmet32', N'1114')
SET IDENTITY_INSERT [dbo].[Tbl_Yonetici] OFF
ALTER TABLE [dbo].[Tbl_Borclar] ADD  CONSTRAINT [DF_Tbl_Borclar_OgrKalanBorc]  DEFAULT ((3000)) FOR [OgrKalanBorc]
GO
ALTER TABLE [dbo].[Tbl_Oda] ADD  CONSTRAINT [DF_Tbl_Oda_OdaAktif]  DEFAULT ((0)) FOR [OdaAktif]
GO
ALTER TABLE [dbo].[Tbl_Oda] ADD  CONSTRAINT [DF_Tbl_Oda_OdaDurum]  DEFAULT ((1)) FOR [OdaDurum]
GO
USE [master]
GO
ALTER DATABASE [YurtOtomasyon] SET  READ_WRITE 
GO
