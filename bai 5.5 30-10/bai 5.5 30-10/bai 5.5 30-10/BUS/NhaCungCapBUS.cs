using System.Collections.Generic;
using InventoryApp.DAL;
using InventoryApp.DTO;

namespace InventoryApp.BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAL _dal = new NhaCungCapDAL();
        public List<NhaCungCapDTO> GetAll() => _dal.GetAll();
    }
}