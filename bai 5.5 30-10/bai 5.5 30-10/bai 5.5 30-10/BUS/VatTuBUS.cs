using System.Collections.Generic;
using InventoryApp.DAL;
using InventoryApp.DTO;

namespace InventoryApp.BUS
{
    public class VatTuBUS
    {
        private VatTuDAL _dal = new VatTuDAL();
        public List<VatTuDTO> GetAll() => _dal.GetAll();
        public List<VatTuDTO> Search(string keyword) => _dal.Search(keyword);
        public List<VatTuDTO> GetCanhBaoTonKho(decimal nguong) => _dal.GetCanhBaoTonKho(nguong);
        public decimal TinhTongGiaTriTonKho() => _dal.TinhTongGiaTriTonKho();
    }
}