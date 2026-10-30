using System;
using InventoryApp.DAL;
using InventoryApp.DTO;

namespace InventoryApp.BUS
{
    public class PhieuKhoBUS
    {
        private PhieuKhoDAL _dal = new PhieuKhoDAL();

        public bool LuuPhieu(PhieuKhoDTO phieu)
        {
            if (phieu.ChiTiets == null || phieu.ChiTiets.Count == 0)
                throw new Exception("Phiếu chưa có mặt hàng nào!");

            if (phieu.LoaiPhieu == "NHAP" && !phieu.MaNCC.HasValue)
                throw new Exception("Phiếu nhập bắt buộc phải chọn Nhà cung cấp!");

            return _dal.LuuPhieuKho(phieu);
        }
    }
}