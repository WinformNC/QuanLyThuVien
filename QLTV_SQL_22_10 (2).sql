/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     10/22/2018 1:04:07 PM                        */
/*==============================================================*/



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
           where  id = object_id('THANHVIEN')
            and   type = 'U')
   drop table THANHVIEN
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
   SOCMND               varchar(10)          null,
   DIACHITHUONGTRU      nvarchar(250)        null,
   SODT                 varchar(10)          null,
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
/* Table: THANHVIEN                                             */
/*==============================================================*/
create table THANHVIEN (
   MATV                 char(5)              not null,
   TENDANGNHAP          varchar(30)          null,
   MASINHVIEN           char(5)              null,
   constraint PK_THANHVIEN primary key (MATV),
   constraint FK_THANHVIE_REFERENCE_TAIKHOAN foreign key (TENDANGNHAP)
      references TAIKHOAN (TENDANGNHAP),
   constraint FK_THANHVIE_REFERENCE_SINHVIEN foreign key (MASINHVIEN)
      references SINHVIEN (MASINHVIEN)
)
go

/*==============================================================*/
/* Table: BIENBANVIPHAM                                         */
/*==============================================================*/
create table BIENBANVIPHAM (
   MAVIPHAM             char(5)              not null,
   MANV                 char(5)              null,
   MATV                 char(5)              null,
   MOTAVIPHAM           nvarchar(1500)       null,
   HUONGXULY            nvarchar(30)         null,
   GHICHU_VP            nvarchar(1000)       null,
   NGAYTHUCTHI          datetime             null,
   NGAYKETTHUC          datetime             null,
   constraint PK_BIENBANVIPHAM primary key (MAVIPHAM),
   constraint FK_BIENBANV_REFERENCE_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV),
   constraint FK_BIENBANV_REFERENCE_THANHVIE foreign key (MATV)
      references THANHVIEN (MATV)
)
go

/*==============================================================*/
/* Table: PHIEUMUONTRA                                          */
/*==============================================================*/
create table PHIEUMUONTRA (
   MAPHIEUMUON          char(5)              not null,
   MANV                 char(5)              null,
   MATV                 char(5)              null,
   NGAYMUON             datetime             null,
   NGAYDUKIENTRA        datetime             null,
   LOAIMUON             nvarchar(50)         null,
   SOLUONGSACHMUON      int                  null,
   PHIMUON              money                null,
   PHICOC               money                null,
   constraint PK_PHIEUMUONTRA primary key (MAPHIEUMUON),
   constraint FK_PHIEUMUO_REFERENCE_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV),
   constraint FK_PHIEUMUO_REFERENCE_THANHVIE foreign key (MATV)
      references THANHVIEN (MATV)
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
   DTTACGIA             varchar(10)              null,
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
   "KEY"                nvarchar(50)         null,
   THANGNHAP            datetime             null,
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

/*==============================================================*/
/* Table: CT_PHIEUMUON                                          */
/*==============================================================*/
create table CT_PHIEUMUON (
   MASACH               char(5)              not null,
   MAPHIEUMUON          char(5)              not null,
   constraint PK_CT_PHIEUMUON primary key (MASACH, MAPHIEUMUON),
   constraint FK_CT_PHIEU_REFERENCE_PHIEUMUO foreign key (MAPHIEUMUON)
      references PHIEUMUONTRA (MAPHIEUMUON),
   constraint FK_CT_PHIEU_REFERENCE_SACH foreign key (MASACH)
      references SACH (MASACH)
)
go

/*==============================================================*/
/* Table: PHIEUNHAP                                             */
/*==============================================================*/
create table PHIEUNHAP (
   MAPHIEUNHAP          char(5)              not null,
   MANV                 char(5)              null,
   NGAYNHAP             datetime             null,
   TIENNHAP             numeric(30)          null,
   constraint PK_PHIEUNHAP primary key (MAPHIEUNHAP),
   constraint FK_PHIEUNHA_REFERENCE_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
)
go

/*==============================================================*/
/* Table: CT_PHIEUNHAP                                          */
/*==============================================================*/
create table CT_PHIEUNHAP (
   MAPHIEUNHAP          char(5)              not null,
   MANXB                char(5)              not null,
   constraint PK_CT_PHIEUNHAP primary key (MAPHIEUNHAP, MANXB),
   constraint FK_CT_PHIEU_REFERENCE_PHIEUNHA foreign key (MAPHIEUNHAP)
      references PHIEUNHAP (MAPHIEUNHAP),
   constraint FK_CT_PHIEU_REFERENCE_NHAXB foreign key (MANXB)
      references NHAXB (MANXB)
)
go

