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
    Magv VARCHAR(20) PRIMARY KEY not null,
    Ten NVARCHAR(50) not null,
    Ngaysinh DATETIME not null,
	Gioi_tinh NVARCHAR(10),
    Email VARCHAR(100) not null,
    Sdt VARCHAR(15) not null,
	FOREIGN KEY (MaTK) REFERENCES TK(MaTK),
)
go
CREATE TABLE Lop (
	Malop VARCHAR(20) PRIMARY KEY not null,
	Tenlop NVARCHAR(50) not null,
)
go
-- Tạo bảng QLsv (Quản lý sinh viên)
CREATE TABLE SV (
    Masv VARCHAR(20) PRIMARY KEY not null,
	MaTK VARCHAR(20) not null,
    Ten NVARCHAR(50) not null,
    Email VARCHAR(100) not null,
    Sdt VARCHAR(15) not null,
    Que_quan NVARCHAR(100) not null,
    ngay_sinh DATETIME not null,
	Gioi_tinh NVARCHAR(10),
    Lop VARCHAR(20) not null,
	FOREIGN KEY (MaTK) REFERENCES TK(MaTK),
	FOREIGN KEY (Lop) REFERENCES Lop(Malop),
)
go

-- Tạo bảng Qldiem (Quản lý điểm)
CREATE TABLE Qldiem (
	Magv VARCHAR(20) not null,
    Masv VARCHAR(20) PRIMARY KEY  not null,
    TenSV NVARCHAR(50) not null,
    Toan Float not null,
    Van Float not null,
    Anh Float not null,
    Su Float not null,
    Dia Float not null,
    FOREIGN KEY (Masv) REFERENCES SV(Masv),
	FOREIGN KEY (Magv) REFERENCES GV(Magv),
)
go

INSERT INTO Chucvu(Macv,Chucvu) VALUES
('CV1','Admin'),
('CV2','Staff'),
('CV3','Member')

INSERT INTO Tk(MaTK,Taikhoan,Macv,Matkhau) VALUES
('TK1', 'admin', 'CV1', '123'),
('TK2', 'staff1', 'CV2', '123'),
('TK3', 'staff2', 'CV2', '123'),
('TK4', 'staff3', 'CV2', '123'),
('TK5', 'staff4', 'CV2', '123'),
('TK6', 'staff5', 'CV2', '123'),
('TK7', 'member1', 'CV3', '123'),
('TK8', 'member2', 'CV3', '123'),
('TK9', 'member3', 'CV3', '123'),
('TK10', 'member4', 'CV3', '123'),
('TK11', 'member5', 'CV3', '123'),
('TK12', 'member6', 'CV3', '123'),
('TK13', 'member7', 'CV3', '123'),
('TK14', 'member8', 'CV3', '123'),
('TK15', 'member9', 'CV3', '123'),
('TK16', 'member10', 'CV3', '123'),
('TK17', 'member11', 'CV3', '123'),
('TK18', 'member12', 'CV3', '123'),
('TK19', 'member13', 'CV3', '123'),
('TK20', 'member14', 'CV3', '123'),
('TK21', 'member15', 'CV3', '123'),
('TK22', 'member16', 'CV3', '123'),
('TK23', 'member17', 'CV3', '123'),
('TK24', 'member18', 'CV3', '123'),
('TK25', 'member19', 'CV3', '123'),
('TK26', 'member20', 'CV3', '123'),
('TK27', 'member21', 'CV3', '123'),
('TK28', 'member22', 'CV3', '123'),
('TK29', 'member23', 'CV3', '123'),
('TK30', 'member24', 'CV3', '123'),
('TK31', 'member25', 'CV3', '123'),
('TK32', 'member26', 'CV3', '123'),
('TK33', 'member27', 'CV3', '123'),
('TK34', 'member28', 'CV3', '123'),
('TK35', 'member29', 'CV3', '123'),
('TK36', 'member30', 'CV3', '123');

-- Thêm dữ liệu mẫu cho bảng GV
INSERT INTO GV (MaTK, Magv, Ten, Ngaysinh, Gioi_tinh, Email, Sdt) VALUES
('TK2', 'GV01', N'Nguyễn Văn A', '1980-01-01', N'Nam', 'a@gmail.com', '0912345678'),
('TK3', 'GV02', N'Trần Thị B', '1985-05-15', N'Nữ', 'b@gmail.com', '0987654321'),
('TK4', 'GV03', N'Lê Minh C', '1990-10-20', N'Nam', 'c@gmail.com', '0934567890'),
('TK5', 'GV04', N'Đặng Thị D', '1978-03-08', N'Nữ', 'd@gmail.com', '0912345679'),
('TK6', 'GV05', N'Phạm Văn E', '1992-07-12', N'Nam', 'e@gmail.com', '0987654320');

INSERT INTO Lop (Malop, Tenlop) VALUES
('L01', N'Lớp A'),
('L02', N'Lớp B'),
('L03', N'Lớp C')


-- Thêm dữ liệu mẫu cho bảng SV
INSERT INTO SV (Masv, MaTK, Ten, Email, Sdt, Que_quan, ngay_sinh, Gioi_tinh, Lop) VALUES
('SV01', 'TK7', N'Nguyễn Văn F', 'f@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nam', 'L01'),
('SV02', 'TK8', N'Trần Thị G', 'g@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nữ', 'L02'),
('SV03', 'TK9', N'Lê Minh H', 'h@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nam', 'L03'),
('SV04', 'TK10', N'Đặng Thị I', 'i@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nữ', 'L01'),
('SV05', 'TK11', N'Phạm Văn J', 'j@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nam', 'L02'),
('SV06', 'TK12', N'Nguyễn Thị K', 'k@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nữ', 'L03'),
('SV07', 'TK13', N'Trần Minh L', 'l@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nam', 'L01'),
('SV08', 'TK14', N'Lê Thị M', 'm@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nữ', 'L02'),
('SV09', 'TK15', N'Đặng Văn N', 'n@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nam', 'L03'),
('SV10', 'TK16', N'Phạm Thị O', 'o@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nữ', 'L01'),
('SV11', 'TK17', N'Nguyễn Văn P', 'p@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nam', 'L02'),
('SV12', 'TK18', N'Trần Thị Q', 'q@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nữ', 'L03'),
('SV13', 'TK19', N'Lê Minh R', 'r@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nam', 'L01'),
('SV14', 'TK20', N'Đặng Thị S', 's@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nữ', 'L02'),
('SV15', 'TK21', N'Phạm Văn T', 't@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nam', 'L03'),
('SV16', 'TK22', N'Nguyễn Thị U', 'u@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nữ', 'L01'),
('SV17', 'TK23', N'Trần Minh V', 'v@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nam', 'L02'),
('SV18', 'TK24', N'Lê Thị W', 'w@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nữ', 'L03'),
('SV19', 'TK25', N'Đặng Văn X', 'x@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nam', 'L01'),
('SV20', 'TK26', N'Phạm Thị Y', 'y@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nữ', 'L02'),
('SV21', 'TK27', N'Nguyễn Văn Z', 'z@gmail.com', '0912345678', N'Hà Nội', '2008-01-01', N'Nam', 'L03'),
('SV22', 'TK28', N'Trần Thị AA', 'aa@gmail.com', '0987654321', N'Hồ Chí Minh', '2008-05-15', N'Nữ', 'L01'),
('SV23', 'TK29', N'Lê Minh BB', 'bb@gmail.com', '0934567890', N'Đà Nẵng', '2008-10-20', N'Nam', 'L02'),
('SV24', 'TK30', N'Đặng Thị CC', 'cc@gmail.com', '0912345679', N'Cần Thơ', '2008-03-08', N'Nữ', 'L03'),
('SV25', 'TK31', N'Phạm Văn DD', 'dd@gmail.com', '0987654320', N'Ninh Bình', '2008-07-12', N'Nam', 'L01');

-- Thêm điểm cho 20 sinh viên
INSERT INTO Qldiem (Magv, Masv, TenSV, Toan, Van, Anh, Su, Dia) VALUES
('GV01', 'SV01', N'Nguyễn Văn F', 8.5, 9.0, 7.5, 8.0, 9.0),
('GV01', 'SV02', N'Trần Thị G', 7.0, 8.5, 8.0, 7.0, 8.0),
('GV01', 'SV03', N'Lê Minh H', 9.0, 8.0, 9.5, 8.5, 9.0),
('GV01', 'SV04', N'Đặng Thị I', 8.0, 7.5, 8.0, 8.5, 9.0),
('GV01', 'SV05', N'Phạm Văn J', 7.5, 8.0, 7.0, 8.0, 8.5),
('GV02', 'SV06', N'Nguyễn Thị K', 8.0, 9.0, 8.5, 7.5, 8.0),
('GV02', 'SV07', N'Trần Minh L', 9.5, 8.0, 9.0, 8.5, 9.0),
('GV02', 'SV08', N'Lê Thị M', 7.0, 8.0, 7.5, 8.0, 8.5),
('GV02', 'SV09', N'Đặng Văn N', 8.5, 9.0, 8.0, 8.0, 8.5),
('GV02', 'SV10', N'Phạm Thị O', 7.5, 8.5, 8.0, 7.0, 8.0),
('GV03', 'SV11', N'Nguyễn Văn P', 9.0, 8.5, 9.0, 8.0, 9.0),
('GV03', 'SV12', N'Trần Thị Q', 8.0, 7.5, 8.0, 8.5, 9.0),
('GV03', 'SV13', N'Lê Minh R', 7.5, 8.0, 7.0, 8.0, 8.5),
('GV03', 'SV14', N'Đặng Thị S', 8.5, 9.0, 8.0, 8.0, 8.5),
('GV03', 'SV15', N'Phạm Văn T', 7.0, 8.0, 7.5, 8.0, 8.5),
('GV04', 'SV16', N'Nguyễn Thị U', 8.0, 9.0, 8.5, 7.5, 8.0),
('GV04', 'SV17', N'Trần Minh V', 9.5, 8.0, 9.0, 8.5, 9.0),
('GV04', 'SV18', N'Lê Thị W', 7.0, 8.0, 7.5, 8.0, 8.5),
('GV04', 'SV19', N'Đặng Văn X', 8.5, 9.0, 8.0, 8.0, 8.5),
('GV04', 'SV20', N'Phạm Thị Y', 7.5, 8.5, 8.0, 7.0, 8.0);
