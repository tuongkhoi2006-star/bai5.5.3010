using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InventoryApp.DTO;

namespace InventoryApp.DAL
{
    public class VatTuDAL
    {
        public List<VatTuDTO> GetAll()
        {
            var list = new List<VatTuDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaVatTu, TenVatTu, DVT, SoLuongTon, DonGiaThamKhao FROM VatTu";
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new VatTuDTO
                        {
                            MaVatTu = reader["MaVatTu"].ToString(),
                            TenVatTu = reader["TenVatTu"].ToString(),
                            DVT = reader["DVT"].ToString(),
                            SoLuongTon = Convert.ToDecimal(reader["SoLuongTon"]),
                            DonGiaThamKhao = Convert.ToDecimal(reader["DonGiaThamKhao"])
                        });
                    }
                }
            }
            return list;
        }

        // Tìm kiếm sử dụng 100% SqlParameter
        public List<VatTuDTO> Search(string keyword)
        {
            var list = new List<VatTuDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM VatTu WHERE MaVatTu LIKE @kw OR TenVatTu LIKE @kw";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@kw", SqlDbType.NVarChar).Value = "%" + keyword + "%";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new VatTuDTO
                            {
                                MaVatTu = reader["MaVatTu"].ToString(),
                                TenVatTu = reader["TenVatTu"].ToString(),
                                DVT = reader["DVT"].ToString(),
                                SoLuongTon = Convert.ToDecimal(reader["SoLuongTon"]),
                                DonGiaThamKhao = Convert.ToDecimal(reader["DonGiaThamKhao"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        // Cảnh báo vật tư dưới ngưỡng định mức
        public List<VatTuDTO> GetCanhBaoTonKho(decimal nguongAnToan)
        {
            var list = new List<VatTuDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM VatTu WHERE SoLuongTon <= @Nguong";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Nguong", SqlDbType.Decimal).Value = nguongAnToan;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new VatTuDTO
                            {
                                MaVatTu = reader["MaVatTu"].ToString(),
                                TenVatTu = reader["TenVatTu"].ToString(),
                                DVT = reader["DVT"].ToString(),
                                SoLuongTon = Convert.ToDecimal(reader["SoLuongTon"]),
                                DonGiaThamKhao = Convert.ToDecimal(reader["DonGiaThamKhao"])
                            });
                        }
                    }
                }
            }
            return list;
        }

        // Thực thi ExecuteScalar tính tổng giá trị hàng tồn kho
        public decimal TinhTongGiaTriTonKho()
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT ISNULL(SUM(SoLuongTon * DonGiaThamKhao), 0) FROM VatTu";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return Convert.ToDecimal(result);
                }
            }
        }
    }
}