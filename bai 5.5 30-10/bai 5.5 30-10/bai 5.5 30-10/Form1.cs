using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using InventoryApp.BUS;
using InventoryApp.DTO;

namespace InventoryApp
{
    public partial class Form1 : Form
    {
        private VatTuBUS _vatTuBus = new VatTuBUS();
        private NhaCungCapBUS _nccBus = new NhaCungCapBUS();
        private PhieuKhoBUS _phieuBus = new PhieuKhoBUS();

        private BindingList<ChiTietPhieuKhoDTO> _listChiTiet = new BindingList<ChiTietPhieuKhoDTO>();
        private List<VatTuDTO> _listVatTuCache = new List<VatTuDTO>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboLoaiPhieu.SelectedIndex = 0; // "NHAP"
            LoadComboboxes();
            LoadDanhSachVatTu();

            dgvChiTiet.DataSource = _listChiTiet;
        }

        private void LoadComboboxes()
        {
            // NCC
            cboNCC.DataSource = _nccBus.GetAll();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";

            // Vat Tu
            _listVatTuCache = _vatTuBus.GetAll();
            cboVatTu.DataSource = _listVatTuCache;
            cboVatTu.DisplayMember = "TenVatTu";
            cboVatTu.ValueMember = "MaVatTu";
        }

        private void LoadDanhSachVatTu()
        {
            dgvVatTu.DataSource = _vatTuBus.GetAll();
        }

        private void cboLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isNhap = cboLoaiPhieu.SelectedItem.ToString() == "NHAP";
            cboNCC.Enabled = isNhap;
            lblNCC.Enabled = isNhap;
        }

        private void cboVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVatTu.SelectedItem is VatTuDTO selected)
            {
                txtDonGia.Text = selected.DonGiaThamKhao.ToString("0");
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if (cboVatTu.SelectedItem == null) return;

            string maVT = cboVatTu.SelectedValue.ToString();
            decimal soLuong = nudSoLuong.Value;
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã trong danh sách chi tiết
            foreach (var item in _listChiTiet)
            {
                if (item.MaVatTu == maVT)
                {
                    item.SoLuong += soLuong;
                    item.DonGia = donGia;
                    dgvChiTiet.Refresh();
                    TinhTongTien();
                    return;
                }
            }

            _listChiTiet.Add(new ChiTietPhieuKhoDTO
            {
                MaVatTu = maVT,
                SoLuong = soLuong,
                DonGia = donGia
            });

            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal total = 0;
            foreach (var ct in _listChiTiet)
            {
                total += ct.ThanhTien;
            }
            lblTongTien.Text = $"Tổng tiền: {total:N0} VNĐ";
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                var phieu = new PhieuKhoDTO
                {
                    LoaiPhieu = cboLoaiPhieu.SelectedItem.ToString(),
                    NgayLap = DateTime.Now,
                    MaNCC = cboLoaiPhieu.SelectedItem.ToString() == "NHAP" ? (int?)cboNCC.SelectedValue : null,
                    TongTien = 0
                };

                foreach (var item in _listChiTiet)
                {
                    phieu.TongTien += item.ThanhTien;
                    phieu.ChiTiets.Add(item);
                }

                // Gọi BUS -> DAL (SqlTransaction)
                if (_phieuBus.LuuPhieu(phieu))
                {
                    MessageBox.Show("Lưu phiếu kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset giao diện
                    _listChiTiet.Clear();
                    TinhTongTien();
                    LoadDanhSachVatTu();
                }
            }
            catch (Exception ex)
            {
                // Khi xảy ra lỗi thiếu hàng hoặc lỗi DB, Transaction đã Rollback
                MessageBox.Show("Thao tác thất bại (Đã khôi phục dữ liệu)!\nLỗi: " + ex.Message, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvVatTu.DataSource = _vatTuBus.Search(txtTimKiem.Text.Trim());
        }

        private void btnCanhBao_Click(object sender, EventArgs e)
        {
            decimal nguong = nudNguongAnToan.Value;
            dgvVatTu.DataSource = _vatTuBus.GetCanhBaoTonKho(nguong);
        }

        private void btnTinhGiaTriKho_Click(object sender, EventArgs e)
        {
            decimal totalValue = _vatTuBus.TinhTongGiaTriTonKho();
            lblGiaTriKho.Text = $"Tổng giá trị tồn: {totalValue:N0} VNĐ";
        }
    }
}