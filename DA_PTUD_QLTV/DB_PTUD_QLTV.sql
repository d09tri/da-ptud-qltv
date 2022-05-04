create database DB_PTUD_QLTV
go
use DB_PTUD_QLTV

create table TheLoai
(
	MaTheLoai int identity(1,1),
	TenTheLoai nvarchar(100),
	constraint PK_TheLoai primary key (MaTheLoai)
)

create table Sach 
(
	MaSach int identity(1,1),
	TenSach nvarchar(100),
	BiaSach nvarchar(100),
	MaTheLoai int,
	NamXuatBan datetime,
	SoLuongSach int,
	constraint PK_Sach primary key (MaSach)
)

create table TacGia
(
	MaTacGia int identity(1,1),
	TenTacGia nvarchar(100),
	constraint PK_TacGia primary key (MaTacGia)
)

-- Một sách sẽ có từ một đến nhiều tác giả, table SachTacGia sẽ đóng vai trò trong việc này
create table SachTacGia
(
	MaSach int,
	MaTacGia int,
	constraint PK_SachTacGia primary key (MaSach, MaTacGia)
)

create table TheThuVien
(
	SoThe int identity(1,1),
	NgayBatDau datetime,
	NgayHetHan datetime,
	T
)

create table DocGia
(

)