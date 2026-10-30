using System;
using System.Collections.Generic;

namespace InventoryApp.DTO
{
    public class PhieuKhoDTO
    {
        public int MaPhieu { get; set; }
        public string LoaiPhieu { get; set; } // "NHAP" hoặc "XUAT"
        public DateTime NgayLap { get; set; }
        public int? MaNCC { get; set; }
        public decimal TongTien { get; set; }
        public List<ChiTietPhieuKhoDTO> ChiTiets { get; set; } = new List<ChiTietPhieuKhoDTO>();
    }
}