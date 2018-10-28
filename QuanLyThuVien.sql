/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     10/22/2018 8:01:46 PM                        */
/*==============================================================*/


create database QuanLyThuVien
if exists (select 1
            from  sysobjects
           where  id = object_id('BIENBANVIPHAM')
            and   type = 'U')
   drop table BIENBANVIPHAM
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHUCVU')
            and   type = 'U')
   drop table CHUCVU
go	

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_PHIEUMUON')
            and   type = 'U')
   drop table CT_PHIEUMUON
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CT_PHIEUNHAP')
            and   type = 'U')
   drop table CT_PHIEUNHAP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHOA')
            and   type = 'U')
   drop table KHOA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHAXB')
            and   type = 'U')
   drop table NHAXB
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUMUONTRA')
            and   type = 'U')
   drop table PHIEUMUONTRA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUNHAP')
            and   type = 'U')
   drop table PHIEUNHAP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SACH')
            and   type = 'U')
   drop table SACH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SINHVIEN')
            and   type = 'U')
   drop table SINHVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TACGIA')
            and   type = 'U')
   drop table TACGIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAIKHOAN')
            and   type = 'U')
   drop table TAIKHOAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THELOAI')
            and   type = 'U')
   drop table THELOAI
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VITRI')
            and   type = 'U')
   drop table VITRI
go

/*==============================================================*/
/* Table: CHUCVU                                                */
/*==============================================================*/
create table CHUCVU (
   MACHUCVU             char(5)              not null,
   TENCHUCVU            nvarchar(50)         null,
   constraint PK_CHUCVU primary key (MACHUCVU)
)
go

/*==============================================================*/
/* Table: TAIKHOAN                                              */
/*==============================================================*/
create table TAIKHOAN (
   TENDANGNHAP          varchar(30)          not null,
   MADANGNHAP           varchar(30)          null,
   LOAITAIKHOAN         varchar(10)          null,
   constraint PK_TAIKHOAN primary key (TENDANGNHAP)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 char(5)              not null,
   MACHUCVU             char(5)              null,
   TENDANGNHAP          varchar(30)          null,
   TENNV                nvarchar(150)        null,
   NGAYSINH             datetime             null,
   SOCMND               nvarchar(20)         null,
   DIACHITHUONGTRU      nvarchar(250)        null,
   SODT                 nvarchar(11)         null,
   EMAIL                nvarchar(150)        null,
   constraint PK_NHANVIEN primary key (MANV),
   constraint FK_NHANVIEN_REFERENCE_CHUCVU foreign key (MACHUCVU)
      references CHUCVU (MACHUCVU),
   constraint FK_NHANVIEN_REFERENCE_TAIKHOAN foreign key (TENDANGNHAP)
      references TAIKHOAN (TENDANGNHAP)
)
go

/*==============================================================*/
/* Table: KHOA                                                  */
/*==============================================================*/
create table KHOA (
   MAKHOA               char(5)              not null,
   TENKHOA              nvarchar(100)        null,
   constraint PK_KHOA primary key (MAKHOA)
)
go

/*==============================================================*/
/* Table: SINHVIEN                                              */
/*==============================================================*/
create table SINHVIEN (
   MASINHVIEN           char(5)              not null,
   MAKHOA               char(5)              null,
   TENSINHVIEN          nvarchar(50)         null,
   NGAYSINH_SV          datetime             null,
   SOCMND_SV            char(20)             null,
   EMAIL_SV             varchar(200)         null,
   DIACHI_SV            nvarchar(500)        null,
   SDT_SV               varchar(11)          null,
   NAMVAOTRUONG         int                  null,
   constraint PK_SINHVIEN primary key (MASINHVIEN),
   constraint FK_SINHVIEN_REFERENCE_KHOA foreign key (MAKHOA)
      references KHOA (MAKHOA)
)
go

/*==============================================================*/
/* Table: PHIEUMUONTRA                                          */
/*==============================================================*/
create table PHIEUMUONTRA (
   MAPHIEUMUON          char(5)              not null,
   MANV                 char(5)              null,
   MASINHVIEN           char(5)              null,
   NGAYMUON             datetime             null,
   NGAYDUKIENTRA        datetime             null,
   PHIMUON              float                null,
   PHICOC               float                null,
   constraint PK_PHIEUMUONTRA primary key (MAPHIEUMUON),
   constraint FK_PHIEUMUO_REFERENCE_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV),
   constraint FK_PHIEUMUO_REFERENCE_SINHVIEN foreign key (MASINHVIEN)
      references SINHVIEN (MASINHVIEN)
)
go

/*==============================================================*/
/* Table: NHAXB                                                 */
/*==============================================================*/
create table NHAXB (
   MANXB                char(5)              not null,
   TENNXB               nvarchar(50)         null,
   DC_NXB               nvarchar(50)         null,
   DT_NXB               varchar(11)          null,
   constraint PK_NHAXB primary key (MANXB)
)
go

/*==============================================================*/
/* Table: THELOAI                                               */
/*==============================================================*/
create table THELOAI (
   MATHELOAI            char(5)              not null,
   TENTHELOAI           nvarchar(30)         null,
   constraint PK_THELOAI primary key (MATHELOAI)
)
go

/*==============================================================*/
/* Table: TACGIA                                                */
/*==============================================================*/
create table TACGIA (
   MATACGIA             char(5)              not null,
   TENTACGIA            nvarchar(30)         null,
   DTTACGIA             nvarchar(11)         null,
   DCTACGIA             nvarchar(50)         null,
   constraint PK_TACGIA primary key (MATACGIA)
)
go

/*==============================================================*/
/* Table: VITRI                                                 */
/*==============================================================*/
create table VITRI (
   MAVITRI              char(5)              not null,
   VITRI                nvarchar(10)         null,
   constraint PK_VITRI primary key (MAVITRI)
)
go

/*==============================================================*/
/* Table: SACH                                                  */
/*==============================================================*/
create table SACH (
   MASACH               char(5)              not null,
   MANXB                char(5)              null,
   MATHELOAI            char(5)              null,
   MATACGIA             char(5)              null,
   MAVITRI              char(5)              null,
   TENSACH              nvarchar(50)         null,
   NAMXB                int                  null,
   HINHANHSACH          nvarchar(100)        null,
   MOTA                 nvarchar(1500)       null,
   SOLUONG				int					null,
   constraint PK_SACH primary key (MASACH),
   constraint FK_SACH_REFERENCE_NHAXB foreign key (MANXB)
      references NHAXB (MANXB),
   constraint FK_SACH_REFERENCE_THELOAI foreign key (MATHELOAI)
      references THELOAI (MATHELOAI),
   constraint FK_SACH_REFERENCE_TACGIA foreign key (MATACGIA)
      references TACGIA (MATACGIA),
   constraint FK_SACH_REFERENCE_VITRI foreign key (MAVITRI)
      references VITRI (MAVITRI)
)
go

create table CHITIETMUONTRA
(
	MAPHIEUMUON          char(5)              not null,
	MASACH char(5) not null,
	NGAYTRA date,
	TINHTRANG nvarchar(50),
	constraint PK_CHITIETMUONTRA primary key (MAPHIEUMUON, MASACH),
	constraint FK_CTMUONTRA_REFERENCE_PHIEUMUON foreign key (MAPHIEUMUON)
      references PHIEUMUONTRA (MAPHIEUMUON),
	constraint  FK_CTMUONTRA_REFERNCE_SACH foreign key (MASACH)
	  references SACH(MASACH)
)
GO

create table PHAT
(
	MAPHAT char(5) not null,
	MASINHVIEN char(5),
	SOTIENPHAT float,
	LYDO nvarchar(30),
	constraint PK_PHAT primary key (MAPHAT),
	constraint FK_PHAT_REFERENCE_SINHVIEN foreign key (MASINHVIEN)
	  references SINHVIEN(MASINHVIEN)
)
insert into THELOAI
values('TL001',N'Công Nghệ'),
('TL002',N'Khoa Học'),
('TL003',N'Thực Phẩm')

insert into NHAXB
values('XB001',N'NXB Trẻ','11111111','090009900'),
('XB002',N'NXB Thanh Niên','112111','090033900'),
('XB003','NXB Vị Thành Niên','111211','09012100')
insert into TACGIA
values('TG001',N'Trần Lê Văn Đức','0900552312','1212121'),
('TG002',N'Nguyễn Thái Bảo','0900532312','12312121'),
('TG003',N'Nguyễn Thanh Quang','09252312','121312321121')
insert into VITRI
values('VT001','A1'),
('VT002','A2'),
('VT003','A3')

CREATE VIEW sachView
as select s.*,TENTACGIA,TENNXB,TENTHELOAI
from Sach s, TACGIA tg, VITRI vt, NHAXB nxb, THELOAI tl
where s.MANXB = nxb.MANXB and s.MATACGIA = tg.MATACGIA and s.MATHELOAI = tl.MATHELOAI and s.MAVITRI = vt.MAVITRI;
select *  from sachView