
CREATE DATABASE QuanLyNhaHang;
GO
USE QuanLyNhaHang;
GO

CREATE TABLE LoaiBan (
    MaLoaiBan VARCHAR(10) PRIMARY KEY,
    TenLoaiBan NVARCHAR(50) NOT NULL,
    MoTa NVARCHAR(255)
);

CREATE TABLE BanNhaHang (
    MaBan VARCHAR(10) PRIMARY KEY,
    TenBan NVARCHAR(50) NOT NULL,
    MaLoaiBan VARCHAR(10) NOT NULL,
    TrangThai NVARCHAR(50),
    SoLuongKhach INT,
    FOREIGN KEY (MaLoaiBan) REFERENCES LoaiBan(MaLoaiBan)
);

CREATE TABLE KhachHang (
    MaKH VARCHAR(10) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10),
    SDT VARCHAR(15),
    Email VARCHAR(100),
    DiaChi NVARCHAR(255),
	DiemTichLuy INT DEFAULT 0
);
CREATE TABLE ThanhVien (
    MaTheThanhVien VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(10) UNIQUE,
    NgayDangKy DATE DEFAULT GETDATE(),
    NgayKichHoat DATE NULL,
    HanSuDung AS DATEADD(YEAR, 2, NgayKichHoat), 
    DiemTichLuy INT DEFAULT 0,
    TrangThai NVARCHAR(20) DEFAULT N'Kích hoạt' CHECK (TrangThai IN(N'Kích Hoạt',N'Đang hoạt động',N'Hết hạn')), 
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE DatBan (
    MaDatBan VARCHAR(10) PRIMARY KEY,
    MaKH VARCHAR(10) NOT NULL,
    MaBan VARCHAR(10) NOT NULL,
    ThoiGianDat DATETIME NOT NULL,
    SoLuongKhach INT,
    YeuCau NVARCHAR(255),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaBan) REFERENCES BanNhaHang(MaBan)
);

CREATE TABLE NhanVien (
    MaNV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(10),
    ChucVu NVARCHAR(50),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100),
    DiaChi NVARCHAR(255),
    HinhAnh NVARCHAR(255),
    TaiKhoan VARCHAR(50),
    MatKhau VARCHAR(255) NOT NULL
);

CREATE TABLE DoanhThu (
    MaDoanhThu VARCHAR(10) PRIMARY KEY,
    Ngay DATE NOT NULL UNIQUE,
    TongDoanhThu DECIMAL(18,2) NOT NULL
);

CREATE TABLE HoaDon (
    MaHoaDon VARCHAR(10) PRIMARY KEY,
    MaDatBan VARCHAR(10) NOT NULL,
    NgayLap DATE NOT NULL,
    TienBan DECIMAL(18,2),
    TienDichVu DECIMAL(18,2),
    PhuPhi DECIMAL(18,2),
    TongTien DECIMAL(18,2) NOT NULL,
    MaNV VARCHAR(10) NOT NULL,
    MaDoanhThu VARCHAR(10) NULL,
    FOREIGN KEY (MaDatBan) REFERENCES DatBan(MaDatBan),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaDoanhThu) REFERENCES DoanhThu(MaDoanhThu)
);

CREATE TABLE LoaiMatHang (
    MaLoaiMH VARCHAR(10) PRIMARY KEY,
    TenLoaiMH NVARCHAR(50) NOT NULL
);

CREATE TABLE MatHang (
    MaMH VARCHAR(10) PRIMARY KEY,
    TenMH NVARCHAR(100) NOT NULL,
	TrangThai NVARCHAR(20) DEFAULT N'Có sẵn' CHECK (TrangThai IN (N'Có sẵn',N'Hết Hàng',N'Tạm dừng')),
	MoTa NVARCHAR(500) NOT NULL,
	ThoiGianCheBien INT NULL,
	HinhAnh NVARCHAR(255) NULL,
    MaLoaiMH VARCHAR(10) NOT NULL,
    Gia DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaLoaiMH) REFERENCES LoaiMatHang(MaLoaiMH) ON UPDATE CASCADE
);

CREATE TABLE ChiTietHoaDon (
    MaCTHD VARCHAR(10) PRIMARY KEY,
    MaHoaDon VARCHAR(10) NOT NULL,
    MaMH VARCHAR(10) NOT NULL,
    SoLuong INT NOT NULL,
    GiaBan DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaMH) REFERENCES MatHang(MaMH)
);

CREATE TABLE DichVuBanAn (
    MaDV VARCHAR(10) PRIMARY KEY,
    MaDatBan VARCHAR(10) NOT NULL,
    MaMH VARCHAR(10) NOT NULL,
    SoLuong INT NOT NULL,
    GiaTaiThoiDiemDat DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaDatBan) REFERENCES DatBan(MaDatBan),
    FOREIGN KEY (MaMH) REFERENCES MatHang(MaMH)
);

CREATE TABLE NhapXuatKho (
    MaNXK VARCHAR(10) PRIMARY KEY,
    MaMH VARCHAR(10) NOT NULL,
    LoaiGiaoDich NVARCHAR(50) CHECK (LoaiGiaoDich IN (N'Nhập', N'Xuất')),
    SoLuong INT NOT NULL,
    NgayGiaoDich DATETIME NOT NULL,
    MaNV VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaMH) REFERENCES MatHang(MaMH),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE CaLamViec (
    MaCa VARCHAR(10) PRIMARY KEY,
    TenCa NVARCHAR(50) NOT NULL,
    GioBatDau TIME NOT NULL,
    GioKetThuc TIME NOT NULL
);

CREATE TABLE ChamCong (
    MaChamCong VARCHAR(10) PRIMARY KEY,
    MaNV VARCHAR(10) NOT NULL,
    MaCa VARCHAR(10) NOT NULL,
    Ngay DATE NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaCa) REFERENCES CaLamViec(MaCa)
);
GO
CREATE TABLE GoiMon (
    MaGoiMon VARCHAR(12) PRIMARY KEY,
    MaDatBan VARCHAR(10) NOT NULL,
    MaNVGoi VARCHAR(10) NULL, 
    ThoiGianGoi DATETIME NOT NULL DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) DEFAULT N'Đang xử lý' CHECK (TrangThai IN(N'Đang xử lý',N'Đã hủy',N'Hoàn tất')), 
    GhiChu NVARCHAR(255) NULL,
    FOREIGN KEY (MaDatBan) REFERENCES DatBan(MaDatBan),
    FOREIGN KEY (MaNVGoi) REFERENCES NhanVien(MaNV)
);
CREATE TABLE GoiMonChiTiet (
    MaGoiMonCT VARCHAR(15) PRIMARY KEY,
    MaGoiMon VARCHAR(12) NOT NULL,
    MaMH VARCHAR(10) NOT NULL,
    SoLuong INT NOT NULL,
    GiaTaiThoiDiem DATETIME NOT NULL DEFAULT GETDATE(),
    TrangThai NVARCHAR(30) DEFAULT N'Đã gọi' CHECK (TrangThai IN(N'Đã gọi',N'Đang chuẩn bị',N'Đã xong',N'Đã Phục vụ',N'Hủy')), 
    MaNVBep VARCHAR(10) NULL, 
    ThoiGianTrangThai DATETIME NULL,
    GhiChu NVARCHAR(255) NULL,
    FOREIGN KEY (MaGoiMon) REFERENCES GoiMon(MaGoiMon),
    FOREIGN KEY (MaMH) REFERENCES MatHang(MaMH),
    FOREIGN KEY (MaNVBep) REFERENCES NhanVien(MaNV)
);
CREATE TABLE ThongBao (
    MaThongBao VARCHAR(12) PRIMARY KEY,
    LoaiThongBao NVARCHAR(50), 
    NoiDung NVARCHAR(500),
    MaNVTo VARCHAR(10) NULL,
    DaDoc BIT DEFAULT 0,
    ThoiGian DATETIME DEFAULT GETDATE(),
    MaGoiMon VARCHAR(12) NULL,
    FOREIGN KEY (MaNVTo) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaGoiMon) REFERENCES GoiMon(MaGoiMon)
);
CREATE TABLE ThanhToan (
    MaThanhToan VARCHAR(12) PRIMARY KEY,
    MaHoaDon VARCHAR(10) NOT NULL,
    LoaiThanhToan NVARCHAR(50) NOT NULL, 
    SoTien DECIMAL(18,2) NOT NULL,
    TienKhachDua DECIMAL(18,2) NULL,
    TienThua DECIMAL(18,2) NULL,
    ThoiGian DATETIME DEFAULT GETDATE(),
    GhiChu NVARCHAR(255) NULL,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
);
CREATE TABLE LichSuTichDiem (
    MaLichSu INT IDENTITY(1,1) PRIMARY KEY,
    MaKH VARCHAR(10) NOT NULL,
    MaHoaDon VARCHAR(10) NULL, 
    NgayGiaoDich DATETIME DEFAULT GETDATE(),
    DiemThayDoi INT NOT NULL, 
    LoaiGiaoDich NVARCHAR(50) NOT NULL, 
    GhiChu NVARCHAR(255) NULL,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);
ALTER TABLE DatBan ADD MaNV VARCHAR(10) NULL;
ALTER TABLE DatBan
ADD CONSTRAINT FK_DatBan_NhanVien
FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);


INSERT INTO LoaiBan (MaLoaiBan, TenLoaiBan, MoTa) VALUES
('LB001', N'Bàn 2 người', N'Phù hợp cho cặp đôi'),
('LB002', N'Bàn 4 người', N'Dành cho nhóm nhỏ'),
('LB003', N'Bàn 6 người', N'Phù hợp gia đình'),
('LB004', N'Bàn 8 người', N'Dùng cho nhóm bạn'),
('LB005', N'Bàn 10 người', N'Tiệc nhỏ'),
('LB006', N'Bàn VIP 4 người', N'Không gian riêng tư'),
('LB007', N'Bàn VIP 8 người', N'Sang trọng'),
('LB008', N'Bàn ngoài trời', N'Hướng gió mát'),
('LB009', N'Bàn trong nhà', N'Không gian yên tĩnh'),
('LB010', N'Bàn quầy bar', N'Phong cách hiện đại');

INSERT INTO BanNhaHang (MaBan, TenBan, MaLoaiBan, TrangThai, SoLuongKhach) VALUES
('B001', N'Bàn 1', 'LB001', N'Trống', 2),
('B002', N'Bàn 2', 'LB002', N'Trống', 4),
('B003', N'Bàn 3', 'LB002', N'Đang sử dụng', 4),
('B004', N'Bàn 4', 'LB003', N'Trống', 6),
('B005', N'Bàn 5', 'LB004', N'Đang sử dụng', 8),
('B006', N'Bàn 6', 'LB005', N'Đã đặt trước', 10),
('B007', N'Bàn 7', 'LB006', N'Trống', 4),
('B008', N'Bàn 8', 'LB007', N'Đang sử dụng', 8),
('B009', N'Bàn 9', 'LB008', N'Trống', 6),
('B010', N'Bàn 10', 'LB009', N'Trống', 4);

INSERT INTO KhachHang (MaKH, TenKH, GioiTinh, Email, SDT, DiaChi) VALUES
('KH001', N'Nguyễn Văn An', N'Nam', 'anan@example.com', '0901111111', N'Quận 1, TP.HCM'),
('KH002', N'Lê Thị Bích', N'Nữ', 'bichlt@example.com', '0902222222', N'Quận 2, TP.HCM'),
('KH003', N'Trần Quốc Cường', N'Nam', 'cuongtq@example.com', '0903333333', N'Quận 3, TP.HCM'),
('KH004', N'Phạm Thu Dung', N'Nữ', 'dungpt@example.com', '0904444444', N'Quận 4, TP.HCM'),
('KH005', N'Hoàng Đức Em', N'Nam', 'emhd@example.com', '0905555555', N'Quận 5, TP.HCM'),
('KH006', N'Đỗ Hồng Phúc', N'Nam', 'phucdh@example.com', '0906666666', N'Quận 6, TP.HCM'),
('KH007', N'Ngô Lan Hương', N'Nữ', 'huongnl@example.com', '0907777777', N'Quận 7, TP.HCM'),
('KH008', N'Bùi Minh Tuấn', N'Nam', 'tuanbm@example.com', '0908888888', N'Quận 8, TP.HCM'),
('KH009', N'Võ Thị Mai', N'Nữ', 'maivt@example.com', '0909999999', N'Quận 9, TP.HCM'),
('KH010', N'Phan Thành Long', N'Nam', 'longpt@example.com', '0910000000', N'Thủ Đức, TP.HCM');

INSERT INTO NhanVien (MaNV, HoTen, GioiTinh, ChucVu, SoDienThoai, Email, DiaChi, HinhAnh, TaiKhoan, MatKhau) VALUES
('NV001', N'Trần Quốc Khánh', N'Nam', N'Quản lý', '0901234567', 'a@example.com', N'Quận 1', NULL, 'nguyenvana', '123456'),
('NV002', N'Nguyễn Thị Thanh Phương', N'Nữ', N'Lễ tân', '0902234567', 'b@example.com', N'Quận 2', NULL, 'tranthib', '123456'),
('NV003', N'Đặng Hoàng Hải', N'Nam', N'Bồi bàn', '0903234567', 'c@example.com', N'Quận 3', NULL, 'levanc', '123456'),
('NV004', N'Lưu Thanh Trúc', N'Nữ', N'Kế toán', '0904234567', 'd@example.com', N'Quận 4', NULL, 'phamthid', '123456'),
('NV005', N'Trần Minh Hòa', N'Nam', N'Bồi bàn', '0905234567', 'e@example.com', N'Quận 5', NULL, 'hoangvane', '123456'),
('NV006', N'Đỗ Thị Hồng Nga', N'Nữ', N'Lễ tân', '0906234567', 'f@example.com', N'Quận 6', NULL, 'dothif', '123456'),
('NV007', N'Hồ Hoàng Liên Sơn', N'Nam', N'Nhân viên', '0907234567', 'g@example.com', N'Quận 7', NULL, 'ngovang', '123456'),
('NV008', N'Bồ Xuân Đức', N'Nam', N'Bồi bàn', '0908234567', 'h@example.com', N'Quận 8', NULL, 'buithih', '123456'),
('NV009', N'Nguyễn Minh Trí', N'Nam', N'Nhân viên', '0909234567', 'i@example.com', N'Quận 9', NULL, 'vovani', '123456'),
('NV010', N'Lê Phúc Anh Huy', N'Nam', N'Kế toán', '0910234567', 'j@example.com', N'Thủ Đức', NULL, 'phanthij', '123456');


INSERT INTO LoaiMatHang (MaLoaiMH, TenLoaiMH) VALUES
('LMH01', N'Món khai vị'),
('LMH02', N'Món chính'),
('LMH03', N'Món phụ'),
('LMH04', N'Món tráng miệng'),
('LMH05', N'Nước ngọt'),
('LMH06', N'Rượu vang'),
('LMH07', N'Sinh tố & nước ép'),
('LMH08', N'Salad'),
('LMH09', N'Súp'),
('LMH10', N'Khác');


INSERT INTO MatHang (MaMH, TenMH, MaLoaiMH, Gia, TrangThai, MoTa, ThoiGianCheBien, HinhAnh) VALUES
('MH001', N'Salad Caesar', 'LMH08', 75000, N'Có sẵn', N'Salad tươi trộn sốt Caesar, phô mai Parmesan và bánh mì nướng', 8, N'SaladScaesar.jpg'),
('MH002', N'Súp bí đỏ kem tươi', 'LMH09', 65000, N'Có sẵn', N'Súp bí đỏ nấu cùng kem tươi và bơ, vị béo nhẹ', 10, N'SupBiDo.jpg'),
('MH003', N'Beefsteak sốt tiêu đen', 'LMH02', 220000, N'Có sẵn', N'Thịt bò nhập khẩu áp chảo vừa chín tới, dùng kèm sốt tiêu đen đậm đà', 20, N'BeefsteaksotTieuDen.jpg'),
('MH004', N'Beefsteak sốt vang đỏ', 'LMH02', 250000, N'Có sẵn', N'Thịt bò Úc nấu cùng sốt vang đỏ, dùng kèm khoai tây nghiền và rau củ hấp', 25, N'SotVang.jpg'),
('MH005', N'Sườn cừu nướng rosemary', 'LMH02', 280000, N'Có sẵn', N'Sườn cừu ướp thảo mộc rosemary, nướng lửa than vừa tới', 30, N'ThitCuuVangDo.jpg'),
('MH006', N'Mì Ý sốt bò bằm', 'LMH03', 150000, N'Có sẵn', N'Spaghetti với sốt cà chua bò bằm đậm đà kiểu Ý', 15, N'MiY.jpg'),
('MH007', N'Bánh chocolate lava', 'LMH04', 95000, N'Có sẵn', N'Bánh chocolate mềm, nhân tan chảy bên trong, ăn kèm kem vani', 12, N'BanhLava.jpg'),
('MH008', N'Nước ép cam tươi', 'LMH07', 55000, N'Có sẵn', N'Nước ép cam tươi nguyên chất, không đường', 3, N'nuocCam.jpg'),
('MH009', N'Rượu vang đỏ Chile', 'LMH06', 320000, N'Có sẵn', N'Rượu vang đỏ nhập khẩu Chile, phù hợp dùng cùng beefsteak', 0, N'RuouVang.jpg'),
('MH010', N'Coca Cola', 'LMH05', 30000, N'Có sẵn', N'Nước giải khát có gas, dùng lạnh', 0, N'CoCa.jpg');

INSERT INTO DatBan (MaDatBan, MaBan, MaKH, ThoiGianDat, SoLuongKhach, YeuCau, TrangThai) VALUES
('DB001', 'B001', 'KH001', '2025-09-10 18:30:00', 2, N'Không hút thuốc', N'Đang sử dụng'),
('DB002', 'B002', 'KH002', '2025-09-10 19:00:00', 4, N'Gần cửa sổ', N'Đang sử dụng'),
('DB003', 'B003', 'KH003', '2025-09-11 11:30:00', 4, N'Thay đổi món chính', N'Đã thanh toán'),
('DB004', 'B004', 'KH004', '2025-09-11 20:00:00', 6, N'Thay ghế trẻ em', N'Đặt trước'),
('DB005', 'B005', 'KH005', '2025-09-12 12:00:00', 8, N'Dọn sạch sẽ trước khi tới', N'Đang sử dụng'),
('DB006', 'B006', 'KH006', '2025-09-12 18:00:00', 10, N'Trang trí sinh nhật', N'Đặt trước'),
('DB007', 'B007', 'KH007', '2025-09-13 19:00:00', 4, N'Cắm hoa tươi', N'Đang sử dụng'),
('DB008', 'B008', 'KH008', '2025-09-13 20:00:00', 8, N'Setup karaoke', N'Đã thanh toán'),
('DB009', 'B009', 'KH009', '2025-09-14 18:30:00', 6, N'Muốn phòng riêng', N'Đang sử dụng'),
('DB010', 'B010', 'KH010', '2025-09-14 19:30:00', 4, N'Có ghế sofa', N'Đang sử dụng');


INSERT INTO DoanhThu (MaDoanhThu, Ngay, TongDoanhThu) VALUES
('DT001', '2025-09-10', 1300000),
('DT002', '2025-09-11', 1800000),
('DT003', '2025-09-12', 3200000),
('DT004', '2025-09-13', 2700000),
('DT005', '2025-09-14', 1800000),
('DT006', '2025-09-01', 9500000), 
('DT007', '2025-08-01', 9000000),
('DT008', '2025-07-01', 8200000),
('DT009', '2025-01-01', 110000000),
('DT010', '2024-01-01', 103000000);

GO


INSERT INTO HoaDon (MaHoaDon, MaDatBan, NgayLap, TienBan, TienDichVu, PhuPhi, TongTien, MaNV, MaDoanhThu) VALUES
('HD001', 'DB001', '2025-09-10', 200000, 300000, 0, 500000, 'NV001', 'DT001'),
('HD002', 'DB002', '2025-09-10', 300000, 400000, 20000, 720000, 'NV002', 'DT001'),
('HD003', 'DB003', '2025-09-11', 250000, 350000, 0, 600000, 'NV003', 'DT002'),
('HD004', 'DB004', '2025-09-11', 500000, 600000, 50000, 1150000, 'NV004', 'DT002'),
('HD005', 'DB005', '2025-09-12', 800000, 900000, 0, 1700000, 'NV005', 'DT003'),
('HD006', 'DB006', '2025-09-12', 1000000, 1200000, 100000, 2300000, 'NV006', 'DT003'),
('HD007', 'DB007', '2025-09-13', 400000, 500000, 0, 900000, 'NV007', 'DT004'),
('HD008', 'DB008', '2025-09-13', 600000, 700000, 50000, 1350000, 'NV008', 'DT004'),
('HD009', 'DB009', '2025-09-14', 450000, 550000, 0, 1000000, 'NV009', 'DT005'),
('HD010', 'DB010', '2025-09-14', 350000, 450000, 20000, 820000, 'NV010', 'DT005');


INSERT INTO ChiTietHoaDon (MaCTHD, MaHoaDon, MaMH, SoLuong, GiaBan) VALUES
('CTHD001', 'HD001', 'MH001', 2, 50000),
('CTHD002', 'HD001', 'MH005', 1, 150000),
('CTHD003', 'HD002', 'MH002', 1, 70000),
('CTHD004', 'HD003', 'MH003', 3, 120000),
('CTHD005', 'HD004', 'MH004', 1, 180000),
('CTHD006', 'HD005', 'MH006', 2, 30000),
('CTHD007', 'HD006', 'MH007', 1, 20000),
('CTHD008', 'HD007', 'MH008', 1, 30000),
('CTHD009', 'HD008', 'MH009', 2, 120000),
('CTHD010', 'HD009', 'MH010', 1, 100000);

INSERT INTO DichVuBanAn (MaDV, MaDatBan, MaMH, SoLuong, GiaTaiThoiDiemDat) VALUES
('DV001', 'DB001', 'MH001', 2, 50000),
('DV002', 'DB001', 'MH007', 2, 20000),
('DV003', 'DB002', 'MH003', 1, 120000),
('DV004', 'DB002', 'MH008', 4, 30000),
('DV005', 'DB003', 'MH004', 2, 180000),
('DV006', 'DB004', 'MH005', 3, 150000),
('DV007', 'DB005', 'MH006', 4, 30000),
('DV008', 'DB006', 'MH009', 2, 120000),
('DV009', 'DB007', 'MH010', 1, 100000),
('DV010', 'DB008', 'MH002', 2, 70000);


INSERT INTO NhapXuatKho (MaNXK, MaMH, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNV) VALUES
('NX001', 'MH001', N'Nhập', 50, '2025-09-09', 'NV001'),
('NX002', 'MH002', N'Nhập', 30, '2025-09-09', 'NV002'),
('NX003', 'MH003', N'Nhập', 40, '2025-09-09', 'NV003'),
('NX004', 'MH004', N'Nhập', 35, '2025-09-09', 'NV004'),
('NX005', 'MH005', N'Nhập', 25, '2025-09-09', 'NV005'),
('NX006', 'MH007', N'Nhập', 100, '2025-09-09', 'NV006'),
('NX007', 'MH008', N'Nhập', 80, '2025-09-09', 'NV007'),
('NX008', 'MH009', N'Nhập', 15, '2025-09-09', 'NV008'),
('NX009', 'MH010', N'Nhập', 30, '2025-09-09', 'NV009'),
('NX010', 'MH001', N'Xuất', 5, '2025-09-10', 'NV010');

INSERT INTO CaLamViec (MaCa, TenCa, GioBatDau, GioKetThuc) VALUES
('CA1', N'Ca sáng', '06:00:00', '12:00:00'),
('CA2', N'Ca chiều', '12:00:00', '18:00:00'),
('CA3', N'Ca tối', '18:00:00', '00:00:00');

INSERT INTO ChamCong (MaChamCong, MaNV, MaCa, Ngay, TrangThai) VALUES
('CC001', 'NV001', 'CA1', '2025-09-10', N'Có mặt'),
('CC002', 'NV002', 'CA2', '2025-09-10', N'Có mặt'),
('CC003', 'NV003', 'CA1', '2025-09-10', N'Có mặt'),
('CC004', 'NV004', 'CA2', '2025-09-10', N'Có mặt'),
('CC005', 'NV005', 'CA3', '2025-09-10', N'Có mặt'),
('CC006', 'NV006', 'CA1', '2025-09-10', N'Có mặt'),
('CC007', 'NV007', 'CA2', '2025-09-10', N'Vắng'),
('CC008', 'NV008', 'CA3', '2025-09-10', N'Có mặt'),
('CC009', 'NV009', 'CA1', '2025-09-10', N'Có mặt'),
('CC010', 'NV010', 'CA2', '2025-09-10', N'Có mặt');
GO
INSERT INTO ThanhVien (MaTheThanhVien, MaKH, NgayDangKy, NgayKichHoat, DiemTichLuy, TrangThai)
VALUES
('OL001', 'KH001', GETDATE(), GETDATE(), 100, N'Đang hoạt động'),
('OL002', 'KH002', GETDATE(), GETDATE(), 150, N'Đang hoạt động'),
('OL003', 'KH003', GETDATE(), GETDATE(), 50, N'Đang hoạt động'),
('OL004', 'KH004', GETDATE(), NULL, 0, N'Kích hoạt'),
('OL005', 'KH005', GETDATE(), '2024-10-01', 200, N'Hết hạn'),
('OL006', 'KH006', GETDATE(), GETDATE(), 90, N'Đang hoạt động'),
('OL007', 'KH007', GETDATE(), GETDATE(), 70, N'Đang hoạt động'),
('OL008', 'KH008', GETDATE(), NULL, 0, N'Kích hoạt'),
('OL009', 'KH009', GETDATE(), GETDATE(), 120, N'Đang hoạt động'),
('OL010', 'KH010', GETDATE(), GETDATE(), 300, N'Đang hoạt động');

INSERT INTO GoiMon (MaGoiMon, MaDatBan, MaNVGoi, TrangThai, GhiChu)
VALUES
('GM001', 'DB001', 'NV003', N'Đang xử lý', N'Khách gọi món chính'),
('GM002', 'DB002', 'NV005', N'Đang xử lý', N'Thêm nước uống'),
('GM003', 'DB003', 'NV003', N'Hoàn tất', N'Món đã phục vụ'),
('GM004', 'DB004', 'NV002', N'Đang xử lý', N'Gọi thêm món phụ'),
('GM005', 'DB005', 'NV008', N'Đang xử lý', N'Thêm món tráng miệng'),
('GM006', 'DB006', 'NV006', N'Đang xử lý', N'Gọi lại món chính'),
('GM007', 'DB007', 'NV009', N'Hoàn tất', N'Đã giao đủ'),
('GM008', 'DB008', 'NV010', N'Đang xử lý', N'Gọi đồ uống'),
('GM009', 'DB009', 'NV005', N'Đang xử lý', N'Thêm nước'),
('GM010', 'DB010', 'NV004', N'Đã hủy', N'Khách hủy món gấp');

INSERT INTO GoiMonChiTiet (MaGoiMonCT, MaGoiMon, MaMH, SoLuong, TrangThai, MaNVBep)
VALUES
('GMCT001', 'GM001', 'MH004', 2, N'Đang chuẩn bị', 'NV001'),
('GMCT002', 'GM001', 'MH007', 2, N'Đã gọi', 'NV001'),
('GMCT003', 'GM002', 'MH005', 1, N'Đã gọi', 'NV001'),
('GMCT004', 'GM003', 'MH003', 3, N'Đã Phục vụ', 'NV001'),
('GMCT005', 'GM004', 'MH001', 2, N'Đã xong', 'NV001'),
('GMCT006', 'GM005', 'MH006', 2, N'Đang chuẩn bị', 'NV001'),
('GMCT007', 'GM006', 'MH002', 1, N'Đã gọi', 'NV001'),
('GMCT008', 'GM007', 'MH008', 2, N'Đã Phục vụ', 'NV001'),
('GMCT009', 'GM008', 'MH009', 1, N'Đã xong', 'NV001'),
('GMCT010', 'GM009', 'MH010', 1, N'Hủy', 'NV001');

INSERT INTO ThongBao (MaThongBao, LoaiThongBao, NoiDung, MaNVTo, MaGoiMon)
VALUES
('TB001', N'Bếp', N'Có đơn mới GM001 cần xử lý', 'NV001', 'GM001'),
('TB002', N'Bếp', N'Món GM002 đã chuẩn bị xong', 'NV001', 'GM002'),
('TB003', N'Nhân viên', N'Món GM003 đã hoàn tất', 'NV005', 'GM003'),
('TB004', N'Bếp', N'Món GM004 cần gấp', 'NV001', 'GM004'),
('TB005', N'Hệ thống', N'Thẻ TV005 sắp hết hạn', NULL, NULL),
('TB006', N'Nhân viên', N'Khách bàn B005 yêu cầu thanh toán', 'NV002', NULL),
('TB007', N'Bếp', N'Có đơn GM006 mới', 'NV001', 'GM006'),
('TB008', N'Nhân viên', N'Món GM008 bị khách hủy', 'NV008', 'GM008'),
('TB009', N'Nhân viên', N'Khách bàn B009 yêu cầu nước', 'NV005', 'GM009'),
('TB010', N'Hệ thống', N'Doanh thu ngày 2025-09-14 đã cập nhật', NULL, NULL);

INSERT INTO LichSuTichDiem (MaKH, MaHoaDon, DiemThayDoi, LoaiGiaoDich, GhiChu) VALUES
('KH001', 'HD001', 15, N'Tích điểm', N'Thưởng cho hóa đơn HD001'),
('KH002', 'HD002', 20, N'Tích điểm', N'Thưởng cho hóa đơn HD002'),
('KH001', NULL, -10, N'Đổi điểm', N'Đổi 10 điểm giảm giá hóa đơn HD003'),
('KH003', 'HD004', 25, N'Tích điểm', N'Hóa đơn ngày 09/10/2025'),	
('KH004', NULL, -5, N'Điều chỉnh', N'Trừ điểm do hủy hóa đơn'),
('KH005', 'HD005', 30, N'Tích điểm', N'Thưởng cho hóa đơn HD005'),
('KH006', 'HD006', 18, N'Tích điểm', N'Hóa đơn thanh toán ngày 08/10/2025'),
('KH007', NULL, -12, N'Đổi điểm', N'Đổi điểm lấy món tráng miệng miễn phí'),
('KH008', 'HD007', 22, N'Tích điểm', N'Thưởng cho khách hàng VIP'),
('KH009', NULL, -8, N'Điều chỉnh', N'Trừ điểm do hoàn món sai đơn');
