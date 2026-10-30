using System;
using System.Data;
using System.Data.SqlClient;
using InventoryApp.DTO;

namespace InventoryApp.DAL
{
    public class PhieuKhoDAL
    {
        public bool LuuPhieuKho(PhieuKhoDTO phieu)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Chèn bản ghi vào bảng PhieuKho
                        string sqlPhieu = @"INSERT INTO PhieuKho (LoaiPhieu, NgayLap, MaNCC, TongTien) 
                                           VALUES (@LoaiPhieu, @NgayLap, @MaNCC, @TongTien);
                                           SELECT SCOPE_IDENTITY();";
                        int maPhieu;
                        using (var cmd = new SqlCommand(sqlPhieu, conn, trans))
                        {
                            cmd.Parameters.Add("@LoaiPhieu", SqlDbType.NVarChar).Value = phieu.LoaiPhieu;
                            cmd.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = phieu.NgayLap;
                            cmd.Parameters.Add("@MaNCC", SqlDbType.Int).Value = (object)phieu.MaNCC ?? DBNull.Value;
                            cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = phieu.TongTien;

                            maPhieu = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Chèn Chi tiết & cập nhật tồn kho từng món
                        foreach (var item in phieu.ChiTiets)
                        {
                            // 2.1 Kiểm tra hàng tồn nếu là phiếu xuất
                            if (phieu.LoaiPhieu == "XUAT")
                            {
                                string sqlCheck = "SELECT SoLuongTon FROM VatTu WITH (UPDLOCK) WHERE MaVatTu = @MaVatTu";
                                decimal tonHienTai = 0;
                                using (var cmdCheck = new SqlCommand(sqlCheck, conn, trans))
                                {
                                    cmdCheck.Parameters.Add("@MaVatTu", SqlDbType.VarChar).Value = item.MaVatTu;
                                    object objTon = cmdCheck.ExecuteScalar();
                                    if (objTon == null)
                                    {
                                        throw new Exception($"Mã vật tư {item.MaVatTu} không tồn tại!");
                                    }
                                    tonHienTai = Convert.ToDecimal(objTon);
                                }

                                if (tonHienTai < item.SoLuong)
                                {
                                    // Yêu cầu: Báo lỗi và rollback
                                    throw new Exception($"Không đủ hàng trong kho cho vật tư {item.MaVatTu}! Hiện còn: {tonHienTai}, Cần xuất: {item.SoLuong}");
                                }
                            }

                            // 2.2 Thêm vào ChiTietPhieuKho
                            string sqlChiTiet = @"INSERT INTO ChiTietPhieuKho (MaPhieu, MaVatTu, SoLuong, DonGia) 
                                                 VALUES (@MaPhieu, @MaVatTu, @SoLuong, @DonGia)";
                            using (var cmdCT = new SqlCommand(sqlChiTiet, conn, trans))
                            {
                                cmdCT.Parameters.Add("@MaPhieu", SqlDbType.Int).Value = maPhieu;
                                cmdCT.Parameters.Add("@MaVatTu", SqlDbType.VarChar).Value = item.MaVatTu;
                                cmdCT.Parameters.Add("@SoLuong", SqlDbType.Decimal).Value = item.SoLuong;
                                cmdCT.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = item.DonGia;
                                cmdCT.ExecuteNonQuery();
                            }

                            // 2.3 Cập nhật số lượng tồn bảng VatTu
                            string sqlUpdateTon = "";
                            if (phieu.LoaiPhieu == "NHAP")
                            {
                                sqlUpdateTon = "UPDATE VatTu SET SoLuongTon = SoLuongTon + @SoLuong WHERE MaVatTu = @MaVatTu";
                            }
                            else // XUAT
                            {
                                sqlUpdateTon = "UPDATE VatTu SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaVatTu = @MaVatTu";
                            }

                            using (var cmdUpdate = new SqlCommand(sqlUpdateTon, conn, trans))
                            {
                                cmdUpdate.Parameters.Add("@SoLuong", SqlDbType.Decimal).Value = item.SoLuong;
                                cmdUpdate.Parameters.Add("@MaVatTu", SqlDbType.VarChar).Value = item.MaVatTu;
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }

                        // 3. Cam kết giao dịch (Commit)
                        trans.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        // Hoàn tác dữ liệu (Rollback)
                        trans.Rollback();
                        throw; // Ném lỗi lên BUS để GUI hiển thị
                    }
                }
            }
        }
    }
}