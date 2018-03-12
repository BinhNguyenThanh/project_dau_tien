Create database Quanlydulich
use Quanlydulich
go

Create table NhanVien
(
MaNV varchar(10) ,
TenNV nvarchar(50),
primary key (MaNV),
)

Create table KhachHang
(
MaKH varchar(10),
TenKH nvarchar(50),
NgaySinh Date,
Tuoi int,
SĐTKH int,
primary key (MaKH),
)

Create table Tour
(
MaTour varchar(10),
TenTour nvarchar(50),
DiaChiTour nvarchar(100),
NgayKhoiHanh Date,
Gia int,
primary key (MaTour)
)

Create table DatTour
(
MaDatTour varchar(10),
MaKH varchar(10),
NgayDat Date,
primary key (MaDatTour),
)

Create table HoaDon
(
MaHD varchar(10),
MaKH varchar(10),
TenNV nvarchar(50),
SDTCty int,
EmailCty nvarchar(100),
website nvarchar(100),
NgayLapHD Date,
NoiDung nvarchar(100),
primary key (MaHD)
)


Create table CTDatTour
(
MaTour varchar(10),
MaHD varchar(10),
SoLuongNguoiLon int,
TenNguoiLon nvarchar(50),
SoLuongTreEm int,
TenTreEm nvarchar(50),
SoLuongTreNho int,
TenTreNho nvarchar(50),
primary key (MaTour,MaHD),
)

Create table CTHoaDon
(
MaTour varchar(10),
MaHD varchar(10),
SoLuongNguoiLon int,
SoLuongTreEm int,
SoLuongTreNho int,
TongCong int,
ThanhTien int,
HinhThucThanhToan nvarchar(100),
primary key (MaTour,MaHD),
)

Create table BangGia
(
MaGiaTour varchar(10),
MaTour varchar(10),
GiaChinh int,
GiaNguoiLon int,
GiaTreEm int,
GiaTreNho int,
primary key (MaGiaTour)
)

select *from Tour
select *from BangGia
select *from NhanVien
select *from KhachHang
select *from DatTour,CTDatTour
select *from HoaDon


