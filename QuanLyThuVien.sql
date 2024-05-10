--Tạo csdl
CREATE DATABASE DBQuanLyThuVien
GO
USE DBQuanLyThuVien

GO
--Tạo bảng tài khoản
CREATE TABLE TaiKhoan
(
	MaTK VARCHAR(10) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	NgaySinh DATETIME NOT NULL,
	GioiTinh NVARCHAR(6) NOT NULL,
	SDT VARCHAR(12),
	MatKhau VARCHAR(30) NOT NULL,
	Quyen BIT NOT NULL,
	TrangThai BIT NOT NULL,

	CONSTRAINT PK_ThuThu PRIMARY KEY (MaTK)
)

--Tạo bảng thẻ độc giả
CREATE TABLE TheDocGia
(
	MaTDG VARCHAR(10) NOT NULL,
	HoTenDG NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(6) NOT NULL,
	DiaChi NVARCHAR(70) NOT NULL,
	SDT VARCHAR(12),
	CCCD VARCHAR(12) NOT NULL,
	NgayTao DATETIME NOT NULL,
	NgayHetHan DATETIME NOT NULL,
	TrangThai BIT NOT NULL,

	CONSTRAINT PK_TheDocGia PRIMARY KEY (MaTDG)
)

--Tạo bảng Sách
CREATE TABLE Sach
(
	MaSach VARCHAR(10) NOT NULL,
	TenSach NVARCHAR(100) NOT NULL,
	MaTL VARCHAR(10) NOT NULL,
	MaTG VARCHAR(10) NOT NULL,
	MaNXB VARCHAR(10) NOT NULL,
	NamXuatBan INT NOT NULL,
	SoLuong INT NOT NULL,
	TrangThai BIT NOT NULL,

	CONSTRAINT PK_Sach PRIMARY KEY (MaSach)
)

--Tạo bảng Sách hỏng
CREATE TABLE SachHong
(
	MaSH VARCHAR(10) NOT NULL,
	MaSach VARCHAR(10) NOT NULL,
	MaTDG VARCHAR(10) NOT NULL,
	MoTa NVARCHAR(30) NOT NULL,
	NgayBaoHong DATETIME NOT NULL,
	TrangThai BIT NOT NULL,

	CONSTRAINT PK_SachHong PRIMARY KEY (MaSH)
)

--Tạo bảng loại sách
CREATE TABLE TheLoai
(
	MaTL VARCHAR(10) NOT NULL,
	TenTL NVARCHAR(50) NOT NULL,
	TrangThai BIT NOT NULL,

	CONSTRAINT PK_TheLoai PRIMARY KEY (MaTL)
)

--Tạo bảng tác giả
CREATE TABLE TacGia
(
	MaTG VARCHAR(10) NOT NULL,
	HoTenTG NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(6) NOT NULL,
	QueQuan NVARCHAR(40) NOT NULL,
	TrangThai BIT NOT NULL,

	CONSTRAINT PK_TacGia PRIMARY KEY (MaTG)
)

--Tạo bảng nhà xuất bản
CREATE TABLE NhaXuatBan
(
	MaNXB VARCHAR(10) NOT NULL,
	TenNXB NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(70) NOT NULL,
	SDT VARCHAR(12),
	TrangThai BIT NOT NULL,

	CONSTRAINT PK_NhaXuatBan PRIMARY KEY (MaNXB)
)

--Tạo bảng phiếu mượn trả
CREATE TABLE PhieuMuonTra
(
	MaPhieu VARCHAR(10) NOT NULL,
	MaTDG VARCHAR(10) NOT NULL,
	MaTK VARCHAR(10) NOT NULL,
	NgayTao DATETIME NOT NULL,
	HanTra DATETIME NOT NULL,
	NgayTra DATETIME,
	DaTra BIT NOT NULL,
	GhiChu NVARCHAR(30),

	CONSTRAINT PK_PhieuMuonTra PRIMARY KEY (MaPhieu)
)

CREATE TABLE CTPhieuMuonTra
(
	MaPhieu VARCHAR(10) NOT NULL,
	MaSach VARCHAR(10) NOT NULL,

	CONSTRAINT PK_CTPhieuMuonTra PRIMARY KEY (MaPhieu, MaSach)
)

--Thêm khóa ngoại bảng Sách
ALTER TABLE Sach ADD CONSTRAINT FK_Sach_TheLoai
FOREIGN KEY (MaTL) REFERENCES TheLoai (MaTL)
ALTER TABLE Sach ADD CONSTRAINT FK_Sach_TacGia
FOREIGN KEY (MaTG) REFERENCES TacGia (MaTG)
ALTER TABLE Sach ADD CONSTRAINT FK_Sach_NhaXuatBan
FOREIGN KEY (MaNXB) REFERENCES NhaXuatBan (MaNXB)

--Thêm khóa ngoại bảng phiếu mượn trả
ALTER TABLE PhieuMuonTra ADD CONSTRAINT FK_PhieuMuonTra_TheDocGia
FOREIGN KEY (MaTDG) REFERENCES TheDocGia (MaTDG)
ALTER TABLE PhieuMuonTra ADD CONSTRAINT FK_PhieuMuonTra_TaiKhoan
FOREIGN KEY (MaTK) REFERENCES TaiKhoan (MaTK)

--Thêm khóa ngoại cho bảng chi tiết phiếu mượn trả
ALTER TABLE CTPhieuMuonTra ADD CONSTRAINT FK_CTPhieuMuonTra_PhieuMuonTra
FOREIGN KEY (MaPhieu) REFERENCES PhieuMuonTra(MaPhieu)
ALTER TABLE CTPhieuMuonTra ADD CONSTRAINT FK_CTPhieuMuonTra_Sach
FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)

--Thêm khóa ngoại cho bảng sách hỏng
ALTER TABLE SachHong ADD CONSTRAINT FK_SachHong_Sach
FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)

GO
--Thêm dữ liệu cho bảng loại sách
INSERT INTO TheLoai VALUES ('TL001', N'Văn học', 1),
						   ('TL002', N'Manga', 1),
						   ('TL003', N'Kiến thức - Khoa học', 1),
						   ('TL004', N'Thiếu nhi', 1)
							
--Thêm dữ liệu cho bảng loại nhà xuất bản
INSERT INTO NhaXuatBan 
VALUES ('NXB001', N'Kim Đồng', N'55 Quang Trung, TP. Hà Nội', '02439434730', 1),
	   ('NXB002', N'Thanh Niên', N'143 Pasteur, Phường 6, Quận 3, TP. Hồ Chí Minh', '02839106963', 1),
	   ('NXB003', N'Thế Giới', N'7 Đ. Nguyễn Thị Minh Khai, Bến Nghé, Quận 1, TP. Hồ Chí Minh', '02838220102', 1),
	   ('NXB004', N'Lao Động', N'97 Trần Quốc Toản, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, TP. Hà Nội', '0438515380', 1),
	   ('NXB005', N'Tri thức', N'19 Phố Duy Tân, Phường Dịch Vọng Hậu, Quận Cầu Giấy, TP. Hà Nội', '0838323839', 1),
	   ('NXB006', N'Trẻ', N'161B Lý Chính Thắng, Phường Võ Thị Sáu, Quận 3 , TP. Hồ Chí Minh', '02839316289', 1)

--Thêm dữ liệu cho bảng tác giả
INSERT INTO TacGia 
VALUES ('TG001', N'Tô Hoài', N'Nam', N'Việt Nam', 1),
	   ('TG002', N'Fujiko F Fujio', N'Nam', N'Nhật Bản', 1),
	   ('TG003', N'Dale Carnegie', N'Nam', N'Hoa Kỳ', 1),
	   ('TG004', N'Chris Hadfield', N'Nam', N'Canada', 1),
	   ('TG005', N'Charlotte Mei', N'Nữ', N'England', 1),
	   ('TG006', N'Lương Hoài Nam', N'Nam', N'Việt Nam', 1),
	   ('TG007', N'Thomas Schelling', N'Nam', N'Hoa Kỳ', 1),
	   ('TG008', N'Pierre Cahuc', N'Nam', N'Pháp', 1),
	   ('TG009', N'Aoyama Gosho', N'Nam', N'Nhật Bản', 1),
	   ('TG010', N'Nguyễn Túc', N'Nam', N'Việt Nam', 1),
	   ('TG011', N'Robin Sharma', N'Nam', N'Canada', 1),
	   ('TG012', N'Yang Phan', N'Nam', N'Việt Nam', 1),
	   ('TG013', N'Nguyễn Nhật Ánh', N'Nam', N'Việt Nam', 1)

--Thêm dữ liệu cho bảng sách
INSERT INTO Sach VALUES ('S001', N'Dế mèn phiêu lưu ký', 'TL001', 'TG001', 'NXB001', 1941, 100, 1),
						('S002', N'Doraemon truyện ngắn - tập 1', 'TL002', 'TG002', 'NXB001', 1993, 100, 1),
						('S003', N'Đánh bại nỗi lo', 'TL003', 'TG003', 'NXB003', 2023, 100, 1),
						('S004', N'Bóng tối bao la', 'TL003', 'TG004', 'NXB002', 2023, 100, 1),
						('S005', N'Pippin học vẽ chân dung', 'TL004', 'TG005', 'NXB002', 2022, 100,  1),
						('S006', N'Kẻ Trăn Trở', 'TL001', 'TG006', 'NXB001', 2015, 100 , 1),
						('S007', N'Vũ khí hạt nhân và ảnh hưởng của nó', 'TL001', 'TG007', 'NXB005', 2023, 100, 1),
						('S008', N'Kinh tế học vi mô mới', 'TL003', 'TG008', 'NXB005', 2015, 100, 1),
						('S009', N'Thám tử lừng danh Conan - tập 1', 'TL002', 'TG009', 'NXB001', 1997, 100, 1),
						('S010', N'Những ánh sao khuê', 'TL001', 'TG010', 'NXB004', 2022, 100, 1),
						('S011', N'Đời ngắn đừng ngủ dài', 'TL003', 'TG011', 'NXB006', 2014, 100, 1),
						('S012', N'Biến thể của cô đơn', 'TL003', 'TG012', 'NXB006', 2024, 100, 1)


--Thêm dữ liệu cho bảng tài khoản
INSERT INTO TaiKhoan VALUES ('TK001', N'Lê Thị Át Min', '1989/05/10', N'Nữ', '0123456789', '123456', 1, 1),
							('TK002', N'Nguyễn Phương Nam', '2004/01/01', N'Nam', '0909010233', '123456', 0, 1),
							('TK003', N'Thái Phi Tuấn', '2004/02/02', N'Nam', '0123987412', '123456', 0, 1)

--Thêm dữ liệu cho bảng thẻ độc giả
INSERT INTO TheDocGia VALUES ('TDG001', N'Trần Văn Vàng', N'Nam', N'TP Đà Lạt, tỉnh Lâm Đồng', 
							  '0112345678', '012321546722', '2024/01/12', '2024/07/10', 1),
							 ('TDG002', N'Nguyễn Bạch Kim', N'Nữ', N'TP Cần Thơ', 
							  '0122345678', '819235215443', '2023/07/26', '2024/01/22', 1),
							 ('TDG003', N'Phạm Tinh Anh', N'Nữ', N'Quận 12, TP Hồ Chí Minh', 
							  '0123345678', '029144325819', '2024/02/05', '2024/08/03', 1),
							 ('TDG004', N'Võ Chí Tôn', N'Nam', N'Rạch Giá, Kiên Giang', 
							  '0912311178', '028195743283', '2023/11/07', '2024/05/05', 1),
							 ('TDG005', N'Lê Kim Cương', N'Nam', N'Quận Bình Thạnh, TP Hồ Chí Minh', 
							  '0123345678', '829314552216', '2024/03/29', '2024/09/25', 1)

--Thêm dữ liệu cho bảng phiếu mượn trả
INSERT INTO PhieuMuonTra VALUES ('P001', 'TDG002', 'TK003', '2023/12/04', '2023/12/25', null, 0, null),
								('P002', 'TDG002', 'TK001', '2023/12/10', '2023/12/31', null, 0, null),
								('P003', 'TDG003', 'TK002', '2024/04/10', '2024/05/01', '2024/04/26', 1, null),
								('P004', 'TDG003', 'TK003', '2024/04/11', '2024/05/02', '2024/04/27', 1, null),
								('P005', 'TDG004', 'TK003', '2024/04/11', '2024/05/02', null, 0, null),
								('P006', 'TDG001', 'TK001', '2024/04/12', '2024/05/03', '2024/04/26', 1, null),
								('P007', 'TDG001', 'TK001', '2024/04/15', '2024/05/06', null, 0, null),
								('P008', 'TDG003', 'TK002', '2024/04/30', '2024/05/21', null, 0, null)
								
								
--Thêm dữ liệu cho bảng chi tiết phiếu mượn
INSERT INTO CTPhieuMuonTra VALUES ('P001', 'S003'), ('P001', 'S009'), ('P002', 'S002'), ('P003', 'S008'),
								  ('P004', 'S011'), ('P004', 'S010'), ('P005', 'S004'), ('P005', 'S005'), 
								  ('P005', 'S007'), ('P006', 'S006'), ('P007', 'S001'), ('P007', 'S012'),
								  ('P008', 'S008'), ('P008', 'S009'), ('P008', 'S003')