create database QLSVDA1
go
use QLSVDA1
go

CREATE TABLE Chucvu (
	Macv VARCHAR(20) PRIMARY KEY not null,
    Chucvu NVARCHAR(30) not null,
)
go

-- Tạo bảng Login
CREATE TABLE TK (
	MaTK VARCHAR(20) PRIMARY KEY not null,
    Taikhoan VARCHAR(50) not null,
    Macv VARCHAR(20)not null,
    Matkhau VARCHAR(255) not null,
	FOREIGN KEY (Macv) REFERENCES Chucvu(Macv)
)
go

-- Tạo bảng GV (Giáo viên)
CREATE TABLE GV (
	MaTK VARCHAR(20) not null,
    Magv VARCHAR PRIMARY KEY not null,
    Ten NVARCHAR(50) not null,
    Ngaysinh DATETIME not null,
    Email VARCHAR(100) not null,
    Sdt VARCHAR(15) not null,
	FOREIGN KEY (MaTK) REFERENCES TK(MaTK),
)
go

-- Tạo bảng QLsv (Quản lý sinh viên)
CREATE TABLE SV (
    Masv VARCHAR(20) PRIMARY KEY not null,
	MaTK VARCHAR(20) not null,
    Ten NVARCHAR(50) not null,
    Email VARCHAR(100) not null,
    Sdt VARCHAR(15) not null,
    Que_quan VARCHAR(100) not null,
    ngay_sinh DATETIME not null,
	Img VARCHAR(100) not null,
    Lop VARCHAR(20) not null,
	FOREIGN KEY (MaTK) REFERENCES TK(MaTK),
)
go

-- Tạo bảng Qldiem (Quản lý điểm)
CREATE TABLE Qldiem (
	Magv VARCHAR  not null,
    Masv VARCHAR(20) not null,
    TenSV VARCHAR(50) not null,
    Toan Float not null,
    Van Float not null,
    Anh Float not null,
    Su Float not null,
    Dia Float not null,
    PRIMARY KEY (Masv),
    FOREIGN KEY (Masv) REFERENCES SV(Masv),
	FOREIGN KEY (Magv) REFERENCES GV(Magv),
)
go