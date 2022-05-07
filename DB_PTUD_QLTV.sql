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

create table SachTacGia
(
	MaSach int,
	MaTacGia int,
	constraint PK_SachTacGia primary key (MaSach, MaTacGia)
)

create table TheThuVien
(
	MaThe int identity(1,1),
	NgayBatDau datetime,
	NgayHetHan datetime,
	GhiChu nvarchar(100),
	TinhTrang bit,
	constraint PK_TheThuVien primary key (MaThe)
)

create table DocGia
(
	MaDocGia int identity(1,1),
	TenDocGia nvarchar(100),
	NgaySinh datetime, 
	SoDienThoai varchar(10),
	MaThe int,
	constraint PK_DocGia primary key (MaDocGia)
)

create table NhanVien
(
	MaNhanVien int identity(1,1),
	TenNhanVien nvarchar(100),
	NgaySinh datetime, 
	SoDienThoai varchar(10),
	constraint PK_NhanVien primary key (MaNhanVien)
)

create table MuonTra
(
	MaMuonTra int identity(1,1),
	MaThe int,
	MaNhanVien int,
	NgayMuon datetime,
	TinhTrang bit,
	constraint PK_MuonTra primary key (MaMuonTra)
)

create table ChiTietMuonTra
(
	MaMuonTra int,
	MaSach int,
	GhiChu nvarchar(100),
	DaTra bit,
	NgayTra datetime,
	constraint PK_ChiTietMuonTra primary key (MaMuonTra, MaSach)
)

alter table Sach add
constraint FK_TheLoai_Sach foreign key (MaTheLoai) references TheLoai (MaTheLoai)

alter table SachTacGia add
constraint FK_Sach_SachTacGia foreign key (MaSach) references Sach (MaSach),
constraint FK_TacGia_SachTacGia foreign key (MaTacGia) references TacGia (MaTacGia)

alter table DocGia add
constraint FK_TheThuVien_DocGia foreign key (MaThe) references TheThuVien (MaThe)

alter table MuonTra add
constraint FK_TheThuVien_MuonTra foreign key (MaThe) references TheThuVien (MaThe),
constraint FK_NhanVien_MuonTra foreign key (MaNhanVien) references NhanVien (MaNhanVien)

alter table ChiTietMuonTra add
constraint FK_MuonTra_CTMT foreign key (MaMuonTra) references MuonTra (MaMuonTra),
constraint FK_Sach_CTMT foreign key (MaSach) references Sach (MaSach)