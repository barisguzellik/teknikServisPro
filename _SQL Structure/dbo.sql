/*
Navicat SQL Server Data Transfer

Target Server Type    : SQL Server
Target Server Version : 120000
File Encoding         : 65001

Date: 2018-03-05 17:40:22
*/


-- ----------------------------
-- Table structure for CARI_KARTLAR_V2
-- ----------------------------
DROP TABLE [dbo].[CARI_KARTLAR_V2]
GO
CREATE TABLE [dbo].[CARI_KARTLAR_V2] (
[ID] int NOT NULL IDENTITY(1,1) ,
[CARI_KODU] nvarchar(255) NULL ,
[UNVANI] nvarchar(255) NULL ,
[CARI_TURU] nvarchar(255) NULL ,
[ADRES] nvarchar(255) NULL ,
[IL] nvarchar(255) NULL ,
[ILCE] nvarchar(255) NULL ,
[TELEFON] nvarchar(255) NULL ,
[CEP_TELEFON] nvarchar(255) NULL ,
[YETKILI_KISI] nvarchar(255) NULL ,
[VERGI_DAIRESI] nvarchar(255) NULL ,
[VERGI_NUMARASI] nvarchar(255) NULL ,
[GRUP_KODU] nvarchar(255) NULL ,
[OZEL_KODLAR_1] nvarchar(255) NULL ,
[OZEL_KODLAR_2] nvarchar(255) NULL ,
[OZEL_KODLAR_3] nvarchar(255) NULL ,
[OZEL_KODLAR_4] nvarchar(255) NULL ,
[OZEL_KODLAR_5] nvarchar(255) NULL ,
[FATURA_ADRESI] nvarchar(MAX) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[CARI_KARTLAR_V2]', RESEED, 6086)
GO

-- ----------------------------
-- Table structure for KULLANICILAR
-- ----------------------------
DROP TABLE [dbo].[KULLANICILAR]
GO
CREATE TABLE [dbo].[KULLANICILAR] (
[ID] int NOT NULL IDENTITY(1,1) ,
[AD] nvarchar(255) NULL ,
[SOYAD] nvarchar(255) NULL ,
[EPOSTA_ADRESI] nvarchar(255) NULL ,
[AKTIF] int NULL ,
[PAROLA] nvarchar(255) NULL ,
[IZINLER] nvarchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[KULLANICILAR]', RESEED, 6)
GO

-- ----------------------------
-- Table structure for SERVIS_FISLERI
-- ----------------------------
DROP TABLE [dbo].[SERVIS_FISLERI]
GO
CREATE TABLE [dbo].[SERVIS_FISLERI] (
[SERVIS_ID] int NOT NULL IDENTITY(1,1) ,
[MUSTERI_ID] int NULL ,
[CIHAZ_MARKASI] varchar(255) NULL ,
[SERVIS_ACIKLAMASI] nvarchar(MAX) NULL ,
[CIHAZ_IMEI] varchar(255) NULL ,
[TESLIM_ALINAN_PARCALAR] nvarchar(MAX) NULL ,
[TUTAR] decimal(20,2) NULL ,
[ODENEN] decimal(20,2) NULL ,
[KALAN] decimal(20,2) NULL ,
[FIS_NUMARASI] varchar(255) NULL ,
[FIS_TARIHI] datetime NULL ,
[KAYIT_TARIHI] nvarchar(255) NULL ,
[DUZENLENME_TARIHI] nvarchar(255) NULL ,
[TESLIM_ALAN] varchar(255) NULL ,
[TESLIM_EDEN] varchar(255) NULL ,
[DURUMU] varchar(255) NULL ,
[DEGISTIRILEN_PARCALAR] nvarchar(MAX) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[SERVIS_FISLERI]', RESEED, 246)
GO

-- ----------------------------
-- Table structure for SETTING_COL_WIDTH
-- ----------------------------
DROP TABLE [dbo].[SETTING_COL_WIDTH]
GO
CREATE TABLE [dbo].[SETTING_COL_WIDTH] (
[ID] int NOT NULL IDENTITY(1,1) ,
[TARGET_GRID] nvarchar(255) NULL ,
[COL] nvarchar(255) NULL ,
[WIDTH] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[SETTING_COL_WIDTH]', RESEED, 264)
GO

-- ----------------------------
-- Indexes structure for table CARI_KARTLAR_V2
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table CARI_KARTLAR_V2
-- ----------------------------
ALTER TABLE [dbo].[CARI_KARTLAR_V2] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Indexes structure for table KULLANICILAR
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table KULLANICILAR
-- ----------------------------
ALTER TABLE [dbo].[KULLANICILAR] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Indexes structure for table SERVIS_FISLERI
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SERVIS_FISLERI
-- ----------------------------
ALTER TABLE [dbo].[SERVIS_FISLERI] ADD PRIMARY KEY ([SERVIS_ID])
GO

-- ----------------------------
-- Indexes structure for table SETTING_COL_WIDTH
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SETTING_COL_WIDTH
-- ----------------------------
ALTER TABLE [dbo].[SETTING_COL_WIDTH] ADD PRIMARY KEY ([ID])
GO
