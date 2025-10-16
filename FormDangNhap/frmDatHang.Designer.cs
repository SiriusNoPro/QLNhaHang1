using System.Drawing;
using System.Windows.Forms;

namespace DOAN
{
    partial class frmDatHang
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            panelLeft = new Panel();
            listLoai = new ListBox();
            flowMenu = new FlowLayoutPanel();
            colTen = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            colChon = new DataGridViewButtonColumn();
            panelRight = new Panel();
            lblTong = new Label();
            lblTongTien = new Label();
            btnXoaGio = new Button();
            btnXoaMon = new Button();
            btnDatHang = new Button();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            cboDatBan = new ComboBox();
            lblDatBan = new Label();
            gridGio = new DataGridView();
            colMaMH = new DataGridViewTextBoxColumn();
            colTenMon = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridGio).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(306, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đặt hàng - Fine Dining Service";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(flowMenu);
            panelLeft.Controls.Add(listLoai);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 60);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(600, 640);
            panelLeft.TabIndex = 1;
            // 
            // listLoai
            // 
            listLoai.Dock = DockStyle.Top;
            listLoai.FormattingEnabled = true;
            listLoai.ItemHeight = 15;
            listLoai.Location = new Point(10, 10);
            listLoai.Name = "listLoai";
            listLoai.Size = new Size(580, 154);
            listLoai.TabIndex = 0;
            listLoai.SelectedIndexChanged += listLoai_SelectedIndexChanged;
            // 
            // flowMenu
            // 
            flowMenu.Dock = DockStyle.Fill;
            flowMenu.Location = new Point(10, 164);
            flowMenu.Name = "flowMenu";
            flowMenu.Size = new Size(580, 466);
            flowMenu.TabIndex = 1;
            // 
            // colTen
            // 
            colTen.DataPropertyName = "TenMH";
            colTen.HeaderText = "Món";
            colTen.Name = "colTen";
            colTen.ReadOnly = true;
            colTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // 
            // colGia
            // 
            colGia.DataPropertyName = "Gia";
            colGia.HeaderText = "Giá";
            colGia.Name = "colGia";
            colGia.ReadOnly = true;
            colGia.Width = 120;
            // 
            // colChon
            // 
            colChon.HeaderText = "";
            colChon.Name = "colChon";
            colChon.ReadOnly = true;
            colChon.Text = "+";
            colChon.UseColumnTextForButtonValue = true;
            colChon.Width = 60;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(lblTongTien);
            panelRight.Controls.Add(lblTong);
            panelRight.Controls.Add(btnXoaGio);
            panelRight.Controls.Add(btnXoaMon);
            panelRight.Controls.Add(btnDatHang);
            panelRight.Controls.Add(txtGhiChu);
            panelRight.Controls.Add(lblGhiChu);
            panelRight.Controls.Add(cboDatBan);
            panelRight.Controls.Add(lblDatBan);
            panelRight.Controls.Add(gridGio);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(600, 60);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(10);
            panelRight.Size = new Size(600, 640);
            panelRight.TabIndex = 2;
            // 
            // gridGio
            // 
            gridGio.AllowUserToAddRows = false;
            gridGio.AllowUserToDeleteRows = false;
            gridGio.BackgroundColor = Color.White;
            gridGio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGio.Columns.AddRange(new DataGridViewColumn[] { colMaMH, colTenMon, colSL, colDonGia, colThanhTien });
            gridGio.Dock = DockStyle.Top;
            gridGio.Location = new Point(10, 10);
            gridGio.MultiSelect = false;
            gridGio.Name = "gridGio";
            gridGio.ReadOnly = true;
            gridGio.RowHeadersVisible = false;
            gridGio.RowTemplate.Height = 40;
            gridGio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridGio.Size = new Size(580, 380);
            gridGio.TabIndex = 0;
            // 
            // colMaMH
            // 
            colMaMH.DataPropertyName = "MaMH";
            colMaMH.HeaderText = "Mã";
            colMaMH.Name = "colMaMH";
            colMaMH.ReadOnly = true;
            colMaMH.Width = 80;
            // 
            // colTenMon
            // 
            colTenMon.DataPropertyName = "TenMH";
            colTenMon.HeaderText = "Món";
            colTenMon.Name = "colTenMon";
            colTenMon.ReadOnly = true;
            colTenMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // 
            // colSL
            // 
            colSL.DataPropertyName = "SoLuong";
            colSL.HeaderText = "SL";
            colSL.Name = "colSL";
            colSL.ReadOnly = true;
            colSL.Width = 60;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            colDonGia.Width = 120;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            colThanhTien.Width = 140;
            // 
            // lblDatBan
            // 
            lblDatBan.AutoSize = true;
            lblDatBan.Location = new Point(13, 404);
            lblDatBan.Name = "lblDatBan";
            lblDatBan.Size = new Size(77, 15);
            lblDatBan.TabIndex = 1;
            lblDatBan.Text = "Chọn đặt bàn";
            // 
            // cboDatBan
            // 
            cboDatBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDatBan.FormattingEnabled = true;
            cboDatBan.Location = new Point(110, 401);
            cboDatBan.Name = "cboDatBan";
            cboDatBan.Size = new Size(200, 23);
            cboDatBan.TabIndex = 2;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(13, 438);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(51, 15);
            lblGhiChu.TabIndex = 3;
            lblGhiChu.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(110, 435);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(480, 60);
            txtGhiChu.TabIndex = 4;
            // 
            // btnDatHang
            // 
            btnDatHang.Location = new Point(490, 570);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(100, 30);
            btnDatHang.TabIndex = 7;
            btnDatHang.Text = "Đặt hàng";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // btnXoaMon
            // 
            btnXoaMon.Location = new Point(270, 570);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(100, 30);
            btnXoaMon.TabIndex = 5;
            btnXoaMon.Text = "Xóa món";
            btnXoaMon.UseVisualStyleBackColor = true;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnXoaGio
            // 
            btnXoaGio.Location = new Point(380, 570);
            btnXoaGio.Name = "btnXoaGio";
            btnXoaGio.Size = new Size(100, 30);
            btnXoaGio.TabIndex = 6;
            btnXoaGio.Text = "Xóa giỏ";
            btnXoaGio.UseVisualStyleBackColor = true;
            btnXoaGio.Click += btnXoaGio_Click;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(13, 510);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(57, 15);
            lblTong.TabIndex = 8;
            lblTong.Text = "Tổng tiền";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(110, 505);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(19, 21);
            lblTongTien.TabIndex = 9;
            lblTongTien.Text = "0";
            // 
            // frmDatHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDatHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDatHang";
            Load += frmDatHang_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridGio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelLeft;
        private ListBox listLoai;
        private FlowLayoutPanel flowMenu;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewButtonColumn colChon;
        private Panel panelRight;
        private DataGridView gridGio;
        private Label lblDatBan;
        private ComboBox cboDatBan;
        private Label lblGhiChu;
        private TextBox txtGhiChu;
        private Button btnDatHang;
        private Button btnXoaMon;
        private Button btnXoaGio;
        private Label lblTong;
        private Label lblTongTien;
        private DataGridViewTextBoxColumn colMaMH;
        private DataGridViewTextBoxColumn colTenMon;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
    }
}


