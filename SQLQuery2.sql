create database QLNV

create table TaiKhoan (
	maTK char(30) primary key,
	Taikhoan char(50),
	Matkhau char(50)
)
create table Nhanvien(
	maNV char(20) primary key,
	maTK char(30),
	Hoten nvarchar(50) ,
	GioiTinh char(10),
	NgaySinh date,
	SĐT char(20),
	Email char(20),
	foreign key (maTK) references TaiKhoan (maTK)
)

create table Sach(
	masach char(20) primary key,
	theloai nvarchar(50) ,
	tensach nvarchar(50) ,
	NXB nvarchar(50),
	giatien int 
)
drop table Sach

create table Kho(
	masach char(20) ,
	soluong int,
	foreign key (masach) references Sach (masach),
)

create table Chitiethoadon(
	maHĐ char(20) primary key,
	masach char(20),
	foreign key (masach) references Sach (masach),
	foreign key (maHĐ) references Hoadon (maHĐ),
	soluong smallint,
	dongia int 
)
drop table Chitiethoadon

create table Hoadon(
	maHĐ char(20) primary key,
	ngayxuat date,
	tongtien int,
	maNV char(20),
	maKH char(20),
	foreign key (maNV) references Nhanvien(maNV)
)
drop table Hoadon

