CREATE DATABASE InventoryDB;
GO
USE InventoryDB;
GO

-- 1. Bảng Nhà Cung Cấp
CREATE TABLE NhaCungCap (
    MaNCC INT IDENTITY(1,1) PRIMARY KEY,
    TenNCC NVARCHAR(150) NOT NULL,
    DienThoai VARCHAR(15) UNIQUE,
    DiaChi NVARCHAR(255)
);

-- 2. Bảng Vật Tư
CREATE TABLE VatTu (
    MaVatTu VARCHAR(20) PRIMARY KEY,
    TenVatTu NVARCHAR(150) NOT NULL,
    DVT NVARCHAR(20),
    SoLuongTon DECIMAL(18,2) DEFAULT 0 CHECK (SoLuongTon >= 0),
    DonGiaThamKhao DECIMAL(18,2) DEFAULT 0 -- Phục vụ tính giá trị tồn kho
);

-- 3. Bảng Phiếu Kho
CREATE TABLE PhieuKho (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
    LoaiPhieu NVARCHAR(10) NOT NULL CHECK (LoaiPhieu IN ('NHAP', 'XUAT')),
    NgayLap DATETIME DEFAULT GETDATE(),
    MaNCC INT NULL FOREIGN KEY REFERENCES NhaCungCap(MaNCC),
    TongTien DECIMAL(18,2) DEFAULT 0
);

-- 4. Bảng Chi Tiết Phiếu Kho
CREATE TABLE ChiTietPhieuKho (
    MaPhieu INT FOREIGN KEY REFERENCES PhieuKho(MaPhieu),
    MaVatTu VARCHAR(20) FOREIGN KEY REFERENCES VatTu(MaVatTu),
    SoLuong DECIMAL(18,2) CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) CHECK (DonGia >= 0),
    PRIMARY KEY (MaPhieu, MaVatTu)
);

-- Dữ liệu mẫu ban đầu
INSERT INTO NhaCungCap (TenNCC, DienThoai, DiaChi) VALUES
(N'Công ty TNHH Thép Việt', '0901234567', N'Hà Nội'),
(N'Nhà phân phối Xi măng Hà Tiên', '0912345678', N'TP.HCM');

INSERT INTO VatTu (MaVatTu, TenVatTu, DVT, SoLuongTon, DonGiaThamKhao) VALUES
('VT01', N'Thép cuộn Phi 6', 'Kg', 1500.00, 15000),
('VT02', N'Xi măng PCB40', N'Bao', 20.00, 85000),
('VT03', N'Cát vàng xây dựng', N'Khối', 5.00, 250000);