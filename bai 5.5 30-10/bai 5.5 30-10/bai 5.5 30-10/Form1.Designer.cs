namespace InventoryApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhieuKho = new System.Windows.Forms.TabPage();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cboVatTu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.cboLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.lblGiaTriKho = new System.Windows.Forms.Label();
            this.btnTinhGiaTriKho = new System.Windows.Forms.Button();
            this.btnCanhBao = new System.Windows.Forms.Button();
            this.nudNguongAnToan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVatTu = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPhieuKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNguongAnToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhieuKho);
            this.tabControl1.Controls.Add(this.tabTonKho);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhieuKho
            // 
            this.tabPhieuKho.Controls.Add(this.btnLuuPhieu);
            this.tabPhieuKho.Controls.Add(this.lblTongTien);
            this.tabPhieuKho.Controls.Add(this.dgvChiTiet);
            this.tabPhieuKho.Controls.Add(this.groupBox2);
            this.tabPhieuKho.Controls.Add(this.groupBox1);
            this.tabPhieuKho.Location = new System.Drawing.Point(4, 25);
            this.tabPhieuKho.Name = "tabPhieuKho";
            this.tabPhieuKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhieuKho.Size = new System.Drawing.Size(876, 532);
            this.tabPhieuKho.TabIndex = 0;
            this.tabPhieuKho.Text = "Lập Phiếu Nhập / Xuất Kho";
            this.tabPhieuKho.UseVisualStyleBackColor = true;
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuuPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieu.Location = new System.Drawing.Point(680, 480);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(180, 40);
            this.btnLuuPhieu.TabIndex = 4;
            this.btnLuuPhieu.Text = "LƯU PHIẾU KHO";
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(20, 485);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(155, 28);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(15, 175);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.Size = new System.Drawing.Size(845, 290);
            this.dgvChiTiet.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemHang);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudSoLuong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboVatTu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(15, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chi tiết mặt hàng";
            // 
            // btnThemHang
            // 
            this.btnThemHang.Location = new System.Drawing.Point(715, 25);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(120, 30);
            this.btnThemHang.TabIndex = 6;
            this.btnThemHang.Text = "Thêm vào DS";
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(555, 28);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(140, 22);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn giá:";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.DecimalPlaces = 2;
            this.nudSoLuong.Location = new System.Drawing.Point(380, 29);
            this.nudSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(90, 22);
            this.nudSoLuong.TabIndex = 3;
            this.nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng:";
            // 
            // cboVatTu
            // 
            this.cboVatTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVatTu.FormattingEnabled = true;
            this.cboVatTu.Location = new System.Drawing.Point(65, 28);
            this.cboVatTu.Name = "cboVatTu";
            this.cboVatTu.Size = new System.Drawing.Size(230, 24);
            this.cboVatTu.TabIndex = 1;
            this.cboVatTu.SelectedIndexChanged += new System.EventHandler(this.cboVatTu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vật tư:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.lblNCC);
            this.groupBox1.Controls.Add(this.cboLoaiPhieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(440, 27);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(380, 24);
            this.cboNCC.TabIndex = 3;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(340, 31);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(93, 16);
            this.lblNCC.TabIndex = 2;
            this.lblNCC.Text = "Nhà cung cấp:";
            // 
            // cboLoaiPhieu
            // 
            this.cboLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhieu.FormattingEnabled = true;
            this.cboLoaiPhieu.Items.AddRange(new object[] { "NHAP", "XUAT" });
            this.cboLoaiPhieu.Location = new System.Drawing.Point(95, 27);
            this.cboLoaiPhieu.Name = "cboLoaiPhieu";
            this.cboLoaiPhieu.Size = new System.Drawing.Size(200, 24);
            this.cboLoaiPhieu.TabIndex = 1;
            this.cboLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhieu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phiếu:";
            // 
            // tabTonKho
            // 
            this.tabTonKho.Controls.Add(this.lblGiaTriKho);
            this.tabTonKho.Controls.Add(this.btnTinhGiaTriKho);
            this.tabTonKho.Controls.Add(this.btnCanhBao);
            this.tabTonKho.Controls.Add(this.nudNguongAnToan);
            this.tabTonKho.Controls.Add(this.label3);
            this.tabTonKho.Controls.Add(this.btnTimKiem);
            this.tabTonKho.Controls.Add(this.txtTimKiem);
            this.tabTonKho.Controls.Add(this.label2);
            this.tabTonKho.Controls.Add(this.dgvVatTu);
            this.tabTonKho.Location = new System.Drawing.Point(4, 25);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonKho.Size = new System.Drawing.Size(876, 532);
            this.tabTonKho.TabIndex = 1;
            this.tabTonKho.Text = "Quản lý & Cảnh báo tồn kho";
            this.tabTonKho.UseVisualStyleBackColor = true;
            // 
            // lblGiaTriKho
            // 
            this.lblGiaTriKho.AutoSize = true;
            this.lblGiaTriKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGiaTriKho.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGiaTriKho.Location = new System.Drawing.Point(230, 485);
            this.lblGiaTriKho.Name = "lblGiaTriKho";
            this.lblGiaTriKho.Size = new System.Drawing.Size(181, 25);
            this.lblGiaTriKho.TabIndex = 8;
            this.lblGiaTriKho.Text = "Tổng giá trị tồn: ---";
            // 
            // btnTinhGiaTriKho
            // 
            this.btnTinhGiaTriKho.Location = new System.Drawing.Point(15, 480);
            this.btnTinhGiaTriKho.Name = "btnTinhGiaTriKho";
            this.btnTinhGiaTriKho.Size = new System.Drawing.Size(190, 35);
            this.btnTinhGiaTriKho.TabIndex = 7;
            this.btnTinhGiaTriKho.Text = "Tính tổng giá trị tồn kho";
            this.btnTinhGiaTriKho.UseVisualStyleBackColor = true;
            this.btnTinhGiaTriKho.Click += new System.EventHandler(this.btnTinhGiaTriKho_Click);
            // 
            // btnCanhBao
            // 
            this.btnCanhBao.BackColor = System.Drawing.Color.Red;
            this.btnCanhBao.ForeColor = System.Drawing.Color.White;
            this.btnCanhBao.Location = new System.Drawing.Point(700, 20);
            this.btnCanhBao.Name = "btnCanhBao";
            this.btnCanhBao.Size = new System.Drawing.Size(160, 30);
            this.btnCanhBao.TabIndex = 6;
            this.btnCanhBao.Text = "Lọc cảnh báo thiếu";
            this.btnCanhBao.UseVisualStyleBackColor = false;
            this.btnCanhBao.Click += new System.EventHandler(this.btnCanhBao_Click);
            // 
            // nudNguongAnToan
            // 
            this.nudNguongAnToan.Location = new System.Drawing.Point(600, 24);
            this.nudNguongAnToan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudNguongAnToan.Name = "nudNguongAnToan";
            this.nudNguongAnToan.Size = new System.Drawing.Size(90, 22);
            this.nudNguongAnToan.TabIndex = 5;
            this.nudNguongAnToan.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Định mức an toàn:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(340, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(145, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(185, 22);
            this.txtTimKiem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm mã/tên vật tư:";
            // 
            // dgvVatTu
            // 
            this.dgvVatTu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatTu.Location = new System.Drawing.Point(15, 65);
            this.dgvVatTu.Name = "dgvVatTu";
            this.dgvVatTu.RowHeadersWidth = 51;
            this.dgvVatTu.Size = new System.Drawing.Size(845, 400);
            this.dgvVatTu.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Xuất - Nhập Kho (Inventory Management)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPhieuKho.ResumeLayout(false);
            this.tabPhieuKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTonKho.ResumeLayout(false);
            this.tabTonKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNguongAnToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhieuKho;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboVatTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.DataGridView dgvVatTu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCanhBao;
        private System.Windows.Forms.NumericUpDown nudNguongAnToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGiaTriKho;
        private System.Windows.Forms.Button btnTinhGiaTriKho;
    }
}