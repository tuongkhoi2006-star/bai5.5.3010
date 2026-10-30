using System.Collections.Generic;
using System.Data.SqlClient;
using InventoryApp.DTO;

namespace InventoryApp.DAL
{
    public class NhaCungCapDAL
    {
        public List<NhaCungCapDTO> GetAll()
        {
            var list = new List<NhaCungCapDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT MaNCC, TenNCC, DienThoai, DiaChi FROM NhaCungCap";
                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhaCungCapDTO
                        {
                            MaNCC = (int)reader["MaNCC"],
                            TenNCC = reader["TenNCC"].ToString(),
                            DienThoai = reader["DienThoai"].ToString(),
                            DiaChi = reader["DiaChi"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}