using System.Drawing;
using System.Windows.Forms;

namespace DOAN
{
    partial class frmDatBan
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
            panelLeft = new Panel();
            gridDatBan = new DataGridView();
            panelFilter = new Panel();
            btnReload = new Button();
            label6 = new Label();
            dtpNgay = new DateTimePicker();
            panelRight = new Panel();
            btnHuy = new Button();
            btnCapNhat = new Button();
            btnTaoMoi = new Button();
            txtYeuCau = new TextBox();
            label5 = new Label();
            numSoLuong = new NumericUpDown();
            label4 = new Label();
            dtpThoiGian = new DateTimePicker();
            label3 = new Label();
            txtMaKH = new TextBox();
            label2 = new Label();
            cboBan = new ComboBox();
            label1 = new Label();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDatBan).BeginInit();
            panelFilter.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(gridDatBan);
            panelLeft.Controls.Add(panelFilter);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(8);
            panelLeft.Size = new Size(620, 600);
            panelLeft.TabIndex = 0;
            // 
            // gridDatBan
            // 
            gridDatBan.AllowUserToAddRows = false;
            gridDatBan.AllowUserToDeleteRows = false;
            gridDatBan.BackgroundColor = Color.White;
            gridDatBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatBan.Dock = DockStyle.Fill;
            gridDatBan.Location = new Point(8, 62);
            gridDatBan.MultiSelect = false;
            gridDatBan.Name = "gridDatBan";
            gridDatBan.ReadOnly = true;
            gridDatBan.RowHeadersVisible = false;
            gridDatBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDatBan.Size = new Size(604, 530);
            gridDatBan.TabIndex = 1;
            gridDatBan.SelectionChanged += gridDatBan_SelectionChanged;
            // 
            // panelFilter
            // 
            panelFilter.Controls.Add(btnReload);
            panelFilter.Controls.Add(label6);
            panelFilter.Controls.Add(dtpNgay);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(8, 8);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(604, 54);
            panelFilter.TabIndex = 0;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(316, 16);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(75, 26);
            btnReload.TabIndex = 2;
            btnReload.Text = "Lọc";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnCapNhat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 20);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 1;
            label6.Text = "Ngày hiển thị";
            // 
            // dtpNgay
            // 
            dtpNgay.CustomFormat = "dd/MM/yyyy";
            dtpNgay.Format = DateTimePickerFormat.Custom;
            dtpNgay.Location = new Point(110, 16);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(190, 23);
            dtpNgay.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(btnHuy);
            panelRight.Controls.Add(btnCapNhat);
            panelRight.Controls.Add(btnTaoMoi);
            panelRight.Controls.Add(txtYeuCau);
            panelRight.Controls.Add(label5);
            panelRight.Controls.Add(numSoLuong);
            panelRight.Controls.Add(label4);
            panelRight.Controls.Add(dtpThoiGian);
            panelRight.Controls.Add(label3);
            panelRight.Controls.Add(txtMaKH);
            panelRight.Controls.Add(label2);
            panelRight.Controls.Add(cboBan);
            panelRight.Controls.Add(label1);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(620, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(12);
            panelRight.Size = new Size(480, 600);
            panelRight.TabIndex = 1;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(382, 248);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(80, 30);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(296, 248);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(80, 30);
            btnCapNhat.TabIndex = 11;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.Location = new Point(210, 248);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(80, 30);
            btnTaoMoi.TabIndex = 10;
            btnTaoMoi.Text = "Tạo mới";
            btnTaoMoi.UseVisualStyleBackColor = true;
            btnTaoMoi.Click += btnTaoMoi_Click;
            // 
            // txtYeuCau
            // 
            txtYeuCau.Location = new Point(110, 166);
            txtYeuCau.Multiline = true;
            txtYeuCau.Name = "txtYeuCau";
            txtYeuCau.Size = new Size(352, 68);
            txtYeuCau.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 169);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Yêu cầu";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(382, 105);
            numSoLuong.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(80, 23);
            numSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 108);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 6;
            label4.Text = "Số lượng KH";
            // 
            // dtpThoiGian
            // 
            dtpThoiGian.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpThoiGian.Format = DateTimePickerFormat.Custom;
            dtpThoiGian.Location = new Point(110, 105);
            dtpThoiGian.Name = "dtpThoiGian";
            dtpThoiGian.Size = new Size(170, 23);
            dtpThoiGian.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 109);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Thời gian";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(110, 64);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(170, 23);
            txtMaKH.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã khách";
            // 
            // cboBan
            // 
            cboBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBan.FormattingEnabled = true;
            cboBan.Location = new Point(110, 23);
            cboBan.Name = "cboBan";
            cboBan.Size = new Size(170, 23);
            cboBan.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Chọn bàn";
            // 
            // frmDatBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDatBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDatBan";
            Load += frmDatBan_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDatBan).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private DataGridView gridDatBan;
        private Panel panelFilter;
        private Button btnReload;
        private Label label6;
        private DateTimePicker dtpNgay;
        private Panel panelRight;
        private Button btnHuy;
        private Button btnCapNhat;
        private Button btnTaoMoi;
        private TextBox txtYeuCau;
        private Label label5;
        private NumericUpDown numSoLuong;
        private Label label4;
        private DateTimePicker dtpThoiGian;
        private Label label3;
        private TextBox txtMaKH;
        private Label label2;
        private ComboBox cboBan;
        private Label label1;
    }
}


