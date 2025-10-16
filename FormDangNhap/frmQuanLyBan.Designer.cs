using System.Drawing;
using System.Windows.Forms;

namespace DOAN
{
    partial class frmQuanLyBan
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
            gridLoai = new DataGridView();
            panelLoaiEdit = new Panel();
            btnLoaiXoa = new Button();
            btnLoaiSua = new Button();
            btnLoaiThem = new Button();
            txtTenLoai = new TextBox();
            txtMaLoai = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelRight = new Panel();
            gridBan = new DataGridView();
            panelBanEdit = new Panel();
            cboTrangThai = new ComboBox();
            numMax = new NumericUpDown();
            btnBanXoa = new Button();
            btnBanSua = new Button();
            btnBanThem = new Button();
            txtTenBan = new TextBox();
            txtMaBan = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cboLoaiBan = new ComboBox();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLoai).BeginInit();
            panelLoaiEdit.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridBan).BeginInit();
            panelBanEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(gridLoai);
            panelLeft.Controls.Add(panelLoaiEdit);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(8);
            panelLeft.Size = new Size(520, 600);
            panelLeft.TabIndex = 0;
            // 
            // gridLoai
            // 
            gridLoai.AllowUserToAddRows = false;
            gridLoai.AllowUserToDeleteRows = false;
            gridLoai.BackgroundColor = Color.White;
            gridLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLoai.Dock = DockStyle.Fill;
            gridLoai.Location = new Point(8, 150);
            gridLoai.MultiSelect = false;
            gridLoai.Name = "gridLoai";
            gridLoai.ReadOnly = true;
            gridLoai.RowHeadersVisible = false;
            gridLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridLoai.Size = new Size(504, 442);
            gridLoai.TabIndex = 1;
            gridLoai.SelectionChanged += gridLoai_SelectionChanged;
            // 
            // panelLoaiEdit
            // 
            panelLoaiEdit.Controls.Add(btnLoaiXoa);
            panelLoaiEdit.Controls.Add(btnLoaiSua);
            panelLoaiEdit.Controls.Add(btnLoaiThem);
            panelLoaiEdit.Controls.Add(txtTenLoai);
            panelLoaiEdit.Controls.Add(txtMaLoai);
            panelLoaiEdit.Controls.Add(label2);
            panelLoaiEdit.Controls.Add(label1);
            panelLoaiEdit.Dock = DockStyle.Top;
            panelLoaiEdit.Location = new Point(8, 8);
            panelLoaiEdit.Name = "panelLoaiEdit";
            panelLoaiEdit.Size = new Size(504, 142);
            panelLoaiEdit.TabIndex = 0;
            // 
            // btnLoaiXoa
            // 
            btnLoaiXoa.Location = new Point(410, 96);
            btnLoaiXoa.Name = "btnLoaiXoa";
            btnLoaiXoa.Size = new Size(75, 28);
            btnLoaiXoa.TabIndex = 6;
            btnLoaiXoa.Text = "Xóa";
            btnLoaiXoa.UseVisualStyleBackColor = true;
            btnLoaiXoa.Click += btnLoaiXoa_Click;
            // 
            // btnLoaiSua
            // 
            btnLoaiSua.Location = new Point(329, 96);
            btnLoaiSua.Name = "btnLoaiSua";
            btnLoaiSua.Size = new Size(75, 28);
            btnLoaiSua.TabIndex = 5;
            btnLoaiSua.Text = "Sửa";
            btnLoaiSua.UseVisualStyleBackColor = true;
            btnLoaiSua.Click += btnLoaiSua_Click;
            // 
            // btnLoaiThem
            // 
            btnLoaiThem.Location = new Point(248, 96);
            btnLoaiThem.Name = "btnLoaiThem";
            btnLoaiThem.Size = new Size(75, 28);
            btnLoaiThem.TabIndex = 4;
            btnLoaiThem.Text = "Thêm";
            btnLoaiThem.UseVisualStyleBackColor = true;
            btnLoaiThem.Click += btnLoaiThem_Click;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(100, 55);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(385, 23);
            txtTenLoai.TabIndex = 3;
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(100, 18);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(180, 23);
            txtMaLoai.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên loại bàn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã loại bàn";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(gridBan);
            panelRight.Controls.Add(panelBanEdit);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(520, 0);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(8);
            panelRight.Size = new Size(580, 600);
            panelRight.TabIndex = 1;
            // 
            // gridBan
            // 
            gridBan.AllowUserToAddRows = false;
            gridBan.AllowUserToDeleteRows = false;
            gridBan.BackgroundColor = Color.White;
            gridBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBan.Dock = DockStyle.Fill;
            gridBan.Location = new Point(8, 180);
            gridBan.MultiSelect = false;
            gridBan.Name = "gridBan";
            gridBan.ReadOnly = true;
            gridBan.RowHeadersVisible = false;
            gridBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBan.Size = new Size(564, 412);
            gridBan.TabIndex = 1;
            gridBan.SelectionChanged += gridBan_SelectionChanged;
            // 
            // panelBanEdit
            // 
            panelBanEdit.Controls.Add(cboTrangThai);
            panelBanEdit.Controls.Add(numMax);
            panelBanEdit.Controls.Add(btnBanXoa);
            panelBanEdit.Controls.Add(btnBanSua);
            panelBanEdit.Controls.Add(btnBanThem);
            panelBanEdit.Controls.Add(txtTenBan);
            panelBanEdit.Controls.Add(txtMaBan);
            panelBanEdit.Controls.Add(label6);
            panelBanEdit.Controls.Add(label5);
            panelBanEdit.Controls.Add(label4);
            panelBanEdit.Controls.Add(label3);
            panelBanEdit.Controls.Add(cboLoaiBan);
            panelBanEdit.Dock = DockStyle.Top;
            panelBanEdit.Location = new Point(8, 8);
            panelBanEdit.Name = "panelBanEdit";
            panelBanEdit.Size = new Size(564, 172);
            panelBanEdit.TabIndex = 0;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Trong", "DaDatTruoc", "DangSuDung" });
            cboTrangThai.Location = new Point(353, 56);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(190, 23);
            cboTrangThai.TabIndex = 11;
            // 
            // numMax
            // 
            numMax.Location = new Point(353, 20);
            numMax.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numMax.Name = "numMax";
            numMax.Size = new Size(120, 23);
            numMax.TabIndex = 10;
            // 
            // btnBanXoa
            // 
            btnBanXoa.Location = new Point(468, 127);
            btnBanXoa.Name = "btnBanXoa";
            btnBanXoa.Size = new Size(75, 28);
            btnBanXoa.TabIndex = 9;
            btnBanXoa.Text = "Xóa";
            btnBanXoa.UseVisualStyleBackColor = true;
            btnBanXoa.Click += btnBanXoa_Click;
            // 
            // btnBanSua
            // 
            btnBanSua.Location = new Point(387, 127);
            btnBanSua.Name = "btnBanSua";
            btnBanSua.Size = new Size(75, 28);
            btnBanSua.TabIndex = 8;
            btnBanSua.Text = "Sửa";
            btnBanSua.UseVisualStyleBackColor = true;
            btnBanSua.Click += btnBanSua_Click;
            // 
            // btnBanThem
            // 
            btnBanThem.Location = new Point(306, 127);
            btnBanThem.Name = "btnBanThem";
            btnBanThem.Size = new Size(75, 28);
            btnBanThem.TabIndex = 7;
            btnBanThem.Text = "Thêm";
            btnBanThem.UseVisualStyleBackColor = true;
            btnBanThem.Click += btnBanThem_Click;
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(88, 92);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(200, 23);
            txtTenBan.TabIndex = 6;
            // 
            // txtMaBan
            // 
            txtMaBan.Location = new Point(88, 56);
            txtMaBan.Name = "txtMaBan";
            txtMaBan.Size = new Size(200, 23);
            txtMaBan.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 59);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 4;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 22);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 3;
            label5.Text = "Số ghế tối đa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 95);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 2;
            label4.Text = "Tên bàn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 59);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 1;
            label3.Text = "Mã bàn";
            // 
            // cboLoaiBan
            // 
            cboLoaiBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiBan.FormattingEnabled = true;
            cboLoaiBan.Location = new Point(88, 18);
            cboLoaiBan.Name = "cboLoaiBan";
            cboLoaiBan.Size = new Size(200, 23);
            cboLoaiBan.TabIndex = 0;
            // 
            // frmQuanLyBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyBan";
            Load += frmQuanLyBan_Load;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridLoai).EndInit();
            panelLoaiEdit.ResumeLayout(false);
            panelLoaiEdit.PerformLayout();
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridBan).EndInit();
            panelBanEdit.ResumeLayout(false);
            panelBanEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private DataGridView gridLoai;
        private Panel panelLoaiEdit;
        private Button btnLoaiXoa;
        private Button btnLoaiSua;
        private Button btnLoaiThem;
        private TextBox txtTenLoai;
        private TextBox txtMaLoai;
        private Label label2;
        private Label label1;
        private Panel panelRight;
        private DataGridView gridBan;
        private Panel panelBanEdit;
        private ComboBox cboTrangThai;
        private NumericUpDown numMax;
        private Button btnBanXoa;
        private Button btnBanSua;
        private Button btnBanThem;
        private TextBox txtTenBan;
        private TextBox txtMaBan;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboLoaiBan;
    }
}


