namespace DOAN
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panelHeader = new Panel();
            lblUserInfo = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panelMenu = new Panel();
            panelsubmenuHeThong = new Panel();
            btnDangXuat = new Button();
            btnCaiDat = new Button();
            btnHeThong = new Button();
            panelsubmenuGiaiTri = new Panel();
            btnSudoku = new Button();
            btnGiaiTri = new Button();
            panelsubmenuThietLap = new Panel();
            btninforNhanVien = new Button();
            btnKhachhang = new Button();
            btnPhong = new Button();
            btnMonAn = new Button();
            btnThietLap = new Button();
            panelsubmenuBaoCao = new Panel();
            btnDoanhThu = new Button();
            btnThongKe = new Button();
            btnBaoCao = new Button();
            panelsubmenuHoatDong = new Panel();
            btnNhapXuatKho = new Button();
            btnDatHang = new Button();
            btnHoaDon = new Button();
            btnDattphong = new Button();
            btnHoatDong = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelTrangchu = new Panel();
            button1 = new Button();
            btnTrangChu = new Button();
            panelChinh = new Panel();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            panelsubmenuHeThong.SuspendLayout();
            panelsubmenuGiaiTri.SuspendLayout();
            panelsubmenuThietLap.SuspendLayout();
            panelsubmenuBaoCao.SuspendLayout();
            panelsubmenuHoatDong.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTrangchu.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblUserInfo);
            panelHeader.Controls.Add(nightControlBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1541, 44);
            panelHeader.TabIndex = 0;
            panelHeader.MouseDown += panel1_MouseDown;
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserInfo.ForeColor = Color.FromArgb(218, 165, 32);
            lblUserInfo.Location = new Point(14, 12);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(123, 20);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "Chưa đăng nhập";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1402, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(74, 44, 44);
            panelMenu.Controls.Add(panelsubmenuHeThong);
            panelMenu.Controls.Add(btnHeThong);
            panelMenu.Controls.Add(panelsubmenuGiaiTri);
            panelMenu.Controls.Add(btnGiaiTri);
            panelMenu.Controls.Add(panelsubmenuThietLap);
            panelMenu.Controls.Add(btnThietLap);
            panelMenu.Controls.Add(panelsubmenuBaoCao);
            panelMenu.Controls.Add(btnBaoCao);
            panelMenu.Controls.Add(panelsubmenuHoatDong);
            panelMenu.Controls.Add(btnHoatDong);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.FromArgb(218, 165, 32);
            panelMenu.Location = new Point(0, 44);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(311, 1112);
            panelMenu.TabIndex = 1;
            // 
            // panelsubmenuHeThong
            // 
            panelsubmenuHeThong.Controls.Add(btnDangXuat);
            panelsubmenuHeThong.Controls.Add(btnCaiDat);
            panelsubmenuHeThong.Dock = DockStyle.Top;
            panelsubmenuHeThong.Location = new Point(0, 1152);
            panelsubmenuHeThong.Margin = new Padding(3, 4, 3, 4);
            panelsubmenuHeThong.Name = "panelsubmenuHeThong";
            panelsubmenuHeThong.Size = new Size(290, 133);
            panelsubmenuHeThong.TabIndex = 11;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 48);
            btnDangXuat.Margin = new Padding(3, 4, 3, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(14, 0, 0, 0);
            btnDangXuat.Size = new Size(290, 48);
            btnDangXuat.TabIndex = 1;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnCaiDat
            // 
            btnCaiDat.Dock = DockStyle.Top;
            btnCaiDat.FlatAppearance.BorderSize = 0;
            btnCaiDat.FlatStyle = FlatStyle.Flat;
            btnCaiDat.Image = (Image)resources.GetObject("btnCaiDat.Image");
            btnCaiDat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaiDat.Location = new Point(0, 0);
            btnCaiDat.Margin = new Padding(3, 4, 3, 4);
            btnCaiDat.Name = "btnCaiDat";
            btnCaiDat.Padding = new Padding(14, 0, 0, 0);
            btnCaiDat.Size = new Size(290, 48);
            btnCaiDat.TabIndex = 0;
            btnCaiDat.Text = "Đăng Nhập";
            btnCaiDat.UseVisualStyleBackColor = true;
            btnCaiDat.Click += btnCaiDat_Click;
            // 
            // btnHeThong
            // 
            btnHeThong.BackColor = Color.FromArgb(74, 44, 44);
            btnHeThong.Dock = DockStyle.Top;
            btnHeThong.FlatStyle = FlatStyle.Flat;
            btnHeThong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeThong.Image = (Image)resources.GetObject("btnHeThong.Image");
            btnHeThong.ImageAlign = ContentAlignment.MiddleLeft;
            btnHeThong.Location = new Point(0, 1057);
            btnHeThong.Margin = new Padding(3, 4, 3, 4);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.Padding = new Padding(14, 0, 0, 0);
            btnHeThong.Size = new Size(290, 95);
            btnHeThong.TabIndex = 10;
            btnHeThong.Text = "    Hệ Thống";
            btnHeThong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHeThong.UseVisualStyleBackColor = true;
            btnHeThong.Click += btnHeThong_Click_1;
            // 
            // panelsubmenuGiaiTri
            // 
            panelsubmenuGiaiTri.Controls.Add(btnSudoku);
            panelsubmenuGiaiTri.Dock = DockStyle.Top;
            panelsubmenuGiaiTri.Location = new Point(0, 964);
            panelsubmenuGiaiTri.Margin = new Padding(3, 4, 3, 4);
            panelsubmenuGiaiTri.Name = "panelsubmenuGiaiTri";
            panelsubmenuGiaiTri.Size = new Size(290, 93);
            panelsubmenuGiaiTri.TabIndex = 12;
            // 
            // btnSudoku
            // 
            btnSudoku.Dock = DockStyle.Top;
            btnSudoku.FlatAppearance.BorderSize = 0;
            btnSudoku.FlatStyle = FlatStyle.Flat;
            btnSudoku.Image = (Image)resources.GetObject("btnSudoku.Image");
            btnSudoku.ImageAlign = ContentAlignment.MiddleLeft;
            btnSudoku.Location = new Point(0, 0);
            btnSudoku.Margin = new Padding(3, 4, 3, 4);
            btnSudoku.Name = "btnSudoku";
            btnSudoku.Padding = new Padding(14, 0, 0, 0);
            btnSudoku.Size = new Size(290, 48);
            btnSudoku.TabIndex = 0;
            btnSudoku.Text = "Phản Hồi Khách Hàng";
            btnSudoku.UseVisualStyleBackColor = true;
            btnSudoku.Click += btnSudoku_Click;
            // 
            // btnGiaiTri
            // 
            btnGiaiTri.BackColor = Color.FromArgb(74, 44, 44);
            btnGiaiTri.Dock = DockStyle.Top;
            btnGiaiTri.FlatStyle = FlatStyle.Flat;
            btnGiaiTri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGiaiTri.Image = (Image)resources.GetObject("btnGiaiTri.Image");
            btnGiaiTri.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiaiTri.Location = new Point(0, 869);
            btnGiaiTri.Margin = new Padding(3, 4, 3, 4);
            btnGiaiTri.Name = "btnGiaiTri";
            btnGiaiTri.Padding = new Padding(14, 0, 0, 0);
            btnGiaiTri.Size = new Size(290, 95);
            btnGiaiTri.TabIndex = 11;
            btnGiaiTri.Text = "    Dịch Vụ Khách Hàng";
            btnGiaiTri.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGiaiTri.UseVisualStyleBackColor = true;
            btnGiaiTri.Click += btnGiaiTri_Click;
            // 
            // panelsubmenuThietLap
            // 
            panelsubmenuThietLap.Controls.Add(btninforNhanVien);
            panelsubmenuThietLap.Controls.Add(btnKhachhang);
            panelsubmenuThietLap.Controls.Add(btnPhong);
            panelsubmenuThietLap.Controls.Add(btnMonAn);
            panelsubmenuThietLap.Dock = DockStyle.Top;
            panelsubmenuThietLap.Location = new Point(0, 661);
            panelsubmenuThietLap.Margin = new Padding(3, 4, 3, 4);
            panelsubmenuThietLap.Name = "panelsubmenuThietLap";
            panelsubmenuThietLap.Size = new Size(290, 208);
            panelsubmenuThietLap.TabIndex = 9;
            // 
            // btninforNhanVien
            // 
            btninforNhanVien.Dock = DockStyle.Top;
            btninforNhanVien.FlatAppearance.BorderSize = 0;
            btninforNhanVien.FlatStyle = FlatStyle.Flat;
            btninforNhanVien.Font = new Font("Times New Roman", 9F);
            btninforNhanVien.Image = (Image)resources.GetObject("btninforNhanVien.Image");
            btninforNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btninforNhanVien.Location = new Point(0, 144);
            btninforNhanVien.Margin = new Padding(3, 4, 3, 4);
            btninforNhanVien.Name = "btninforNhanVien";
            btninforNhanVien.Padding = new Padding(14, 0, 0, 0);
            btninforNhanVien.Size = new Size(290, 48);
            btninforNhanVien.TabIndex = 3;
            btninforNhanVien.Text = "Nhân Viên Nhà Hàng";
            btninforNhanVien.UseVisualStyleBackColor = true;
            btninforNhanVien.Click += btninforNhanVien_Click;
            // 
            // btnKhachhang
            // 
            btnKhachhang.Dock = DockStyle.Top;
            btnKhachhang.FlatAppearance.BorderSize = 0;
            btnKhachhang.FlatStyle = FlatStyle.Flat;
            btnKhachhang.Font = new Font("Times New Roman", 9F);
            btnKhachhang.Image = (Image)resources.GetObject("btnKhachhang.Image");
            btnKhachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachhang.Location = new Point(0, 96);
            btnKhachhang.Margin = new Padding(3, 4, 3, 4);
            btnKhachhang.Name = "btnKhachhang";
            btnKhachhang.Padding = new Padding(14, 0, 0, 0);
            btnKhachhang.Size = new Size(290, 48);
            btnKhachhang.TabIndex = 2;
            btnKhachhang.Text = "Khách Hàng Nhà Hàng";
            btnKhachhang.UseVisualStyleBackColor = true;
            btnKhachhang.Click += btnKhachhang_Click;
            // 
            // btnPhong
            // 
            btnPhong.Dock = DockStyle.Top;
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Font = new Font("Times New Roman", 9F);
            btnPhong.Image = (Image)resources.GetObject("btnPhong.Image");
            btnPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhong.Location = new Point(0, 48);
            btnPhong.Margin = new Padding(3, 4, 3, 4);
            btnPhong.Name = "btnPhong";
            btnPhong.Padding = new Padding(14, 0, 0, 0);
            btnPhong.Size = new Size(290, 48);
            btnPhong.TabIndex = 1;
            btnPhong.Text = "Quản Lý Bàn";
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // btnMonAn
            // 
            btnMonAn.Dock = DockStyle.Top;
            btnMonAn.FlatAppearance.BorderSize = 0;
            btnMonAn.FlatStyle = FlatStyle.Flat;
            btnMonAn.Font = new Font("Times New Roman", 9F);
            btnMonAn.Image = (Image)resources.GetObject("btnMonAn.Image");
            btnMonAn.ImageAlign = ContentAlignment.MiddleLeft;
            btnMonAn.Location = new Point(0, 0);
            btnMonAn.Margin = new Padding(3, 4, 3, 4);
            btnMonAn.Name = "btnMonAn";
            btnMonAn.Padding = new Padding(14, 0, 0, 0);
            btnMonAn.Size = new Size(290, 48);
            btnMonAn.TabIndex = 0;
            btnMonAn.Text = "Thực Đơn";
            btnMonAn.UseVisualStyleBackColor = true;
            btnMonAn.Click += btnMonAn_Click;
            // 
            // btnThietLap
            // 
            btnThietLap.BackColor = Color.FromArgb(74, 44, 44);
            btnThietLap.Dock = DockStyle.Top;
            btnThietLap.FlatStyle = FlatStyle.Flat;
            btnThietLap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThietLap.Image = (Image)resources.GetObject("btnThietLap.Image");
            btnThietLap.ImageAlign = ContentAlignment.MiddleLeft;
            btnThietLap.Location = new Point(0, 566);
            btnThietLap.Margin = new Padding(3, 4, 3, 4);
            btnThietLap.Name = "btnThietLap";
            btnThietLap.Padding = new Padding(14, 0, 0, 0);
            btnThietLap.Size = new Size(290, 95);
            btnThietLap.TabIndex = 8;
            btnThietLap.Text = "    Thiết Lập Nhà Hàng";
            btnThietLap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThietLap.UseVisualStyleBackColor = true;
            btnThietLap.Click += btnThietLap_Click;
            // 
            // panelsubmenuBaoCao
            // 
            panelsubmenuBaoCao.Controls.Add(btnDoanhThu);
            panelsubmenuBaoCao.Controls.Add(btnThongKe);
            panelsubmenuBaoCao.Dock = DockStyle.Top;
            panelsubmenuBaoCao.Location = new Point(0, 479);
            panelsubmenuBaoCao.Margin = new Padding(3, 4, 3, 4);
            panelsubmenuBaoCao.Name = "panelsubmenuBaoCao";
            panelsubmenuBaoCao.Size = new Size(290, 87);
            panelsubmenuBaoCao.TabIndex = 7;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.Dock = DockStyle.Top;
            btnDoanhThu.FlatAppearance.BorderSize = 0;
            btnDoanhThu.FlatStyle = FlatStyle.Flat;
            btnDoanhThu.Font = new Font("Times New Roman", 9F);
            btnDoanhThu.Image = (Image)resources.GetObject("btnDoanhThu.Image");
            btnDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoanhThu.Location = new Point(0, 48);
            btnDoanhThu.Margin = new Padding(3, 4, 3, 4);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Padding = new Padding(14, 0, 0, 0);
            btnDoanhThu.Size = new Size(290, 48);
            btnDoanhThu.TabIndex = 1;
            btnDoanhThu.Text = "Doanh Thu";
            btnDoanhThu.UseVisualStyleBackColor = true;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongKe.Image = (Image)resources.GetObject("btnThongKe.Image");
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 0);
            btnThongKe.Margin = new Padding(3, 4, 3, 4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(14, 0, 0, 0);
            btnThongKe.Size = new Size(290, 48);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.FromArgb(74, 44, 44);
            btnBaoCao.Dock = DockStyle.Top;
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaoCao.Image = (Image)resources.GetObject("btnBaoCao.Image");
            btnBaoCao.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.Location = new Point(0, 384);
            btnBaoCao.Margin = new Padding(3, 4, 3, 4);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(14, 0, 0, 0);
            btnBaoCao.Size = new Size(290, 95);
            btnBaoCao.TabIndex = 6;
            btnBaoCao.Text = "    Báo Cáo Doanh Thu";
            btnBaoCao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaoCao.UseVisualStyleBackColor = true;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // panelsubmenuHoatDong
            // 
            panelsubmenuHoatDong.Controls.Add(btnNhapXuatKho);
            panelsubmenuHoatDong.Controls.Add(btnHoaDon);
            panelsubmenuHoatDong.Controls.Add(btnDattphong);
            panelsubmenuHoatDong.Controls.Add(btnDatHang);
            panelsubmenuHoatDong.Dock = DockStyle.Top;
            panelsubmenuHoatDong.Location = new Point(0, 236);
            panelsubmenuHoatDong.Margin = new Padding(3, 4, 3, 4);
            panelsubmenuHoatDong.Name = "panelsubmenuHoatDong";
            panelsubmenuHoatDong.Size = new Size(290, 148);
            panelsubmenuHoatDong.TabIndex = 5;
            // 
            // btnNhapXuatKho
            // 
            btnNhapXuatKho.Dock = DockStyle.Top;
            btnNhapXuatKho.FlatAppearance.BorderSize = 0;
            btnNhapXuatKho.FlatStyle = FlatStyle.Flat;
            btnNhapXuatKho.Font = new Font("Times New Roman", 9.75F);
            btnNhapXuatKho.Image = (Image)resources.GetObject("btnNhapXuatKho.Image");
            btnNhapXuatKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapXuatKho.Location = new Point(0, 96);
            btnNhapXuatKho.Margin = new Padding(3, 4, 3, 4);
            btnNhapXuatKho.Name = "btnNhapXuatKho";
            btnNhapXuatKho.Padding = new Padding(14, 0, 0, 0);
            btnNhapXuatKho.Size = new Size(290, 48);
            btnNhapXuatKho.TabIndex = 2;
            btnNhapXuatKho.Text = "Quản Lý Kho";
            btnNhapXuatKho.UseVisualStyleBackColor = true;
            btnNhapXuatKho.Click += btnNhapXuatKho_Click;
            // 
            // btnDatHang
            // 
            btnDatHang.Dock = DockStyle.Top;
            btnDatHang.FlatAppearance.BorderSize = 0;
            btnDatHang.FlatStyle = FlatStyle.Flat;
            btnDatHang.Font = new Font("Times New Roman", 9.75F);
            btnDatHang.Image = (Image)resources.GetObject("btnHoaDon.Image");
            btnDatHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatHang.Location = new Point(0, 144);
            btnDatHang.Margin = new Padding(3, 4, 3, 4);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Padding = new Padding(14, 0, 0, 0);
            btnDatHang.Size = new Size(290, 48);
            btnDatHang.TabIndex = 3;
            btnDatHang.Text = "Đặt Hàng Nhà Hàng";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Times New Roman", 9.75F);
            btnHoaDon.Image = (Image)resources.GetObject("btnHoaDon.Image");
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 48);
            btnHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(14, 0, 0, 0);
            btnHoaDon.Size = new Size(290, 48);
            btnHoaDon.TabIndex = 1;
            btnHoaDon.Text = "Hóa Đơn Nhà Hàng";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnDattphong
            // 
            btnDattphong.Dock = DockStyle.Top;
            btnDattphong.FlatAppearance.BorderSize = 0;
            btnDattphong.FlatStyle = FlatStyle.Flat;
            btnDattphong.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDattphong.Image = (Image)resources.GetObject("btnDattphong.Image");
            btnDattphong.ImageAlign = ContentAlignment.MiddleLeft;
            btnDattphong.Location = new Point(0, 0);
            btnDattphong.Margin = new Padding(3, 4, 3, 4);
            btnDattphong.Name = "btnDattphong";
            btnDattphong.Padding = new Padding(14, 0, 0, 0);
            btnDattphong.Size = new Size(290, 48);
            btnDattphong.TabIndex = 0;
            btnDattphong.Text = "Đặt Bàn";
            btnDattphong.UseVisualStyleBackColor = true;
            btnDattphong.Click += btnDatPhong_Click;
            // 
            // btnHoatDong
            // 
            btnHoatDong.BackColor = Color.FromArgb(74, 44, 44);
            btnHoatDong.Dock = DockStyle.Top;
            btnHoatDong.FlatStyle = FlatStyle.Flat;
            btnHoatDong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoatDong.ForeColor = Color.FromArgb(218, 165, 32);
            btnHoatDong.Image = (Image)resources.GetObject("btnHoatDong.Image");
            btnHoatDong.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoatDong.Location = new Point(0, 141);
            btnHoatDong.Margin = new Padding(3, 4, 3, 4);
            btnHoatDong.Name = "btnHoatDong";
            btnHoatDong.Padding = new Padding(14, 0, 0, 0);
            btnHoatDong.Size = new Size(290, 95);
            btnHoatDong.TabIndex = 0;
            btnHoatDong.Text = "    Quản Lý Đơn Hàng";
            btnHoatDong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoatDong.UseVisualStyleBackColor = false;
            btnHoatDong.Click += btnHeThong_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(74, 44, 44);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(290, 141);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(80, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTrangchu
            // 
            panelTrangchu.BackColor = Color.FromArgb(74, 44, 44);
            panelTrangchu.Controls.Add(button1);
            panelTrangchu.Controls.Add(btnTrangChu);
            panelTrangchu.Dock = DockStyle.Top;
            panelTrangchu.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTrangchu.ForeColor = Color.FromArgb(255, 255, 255);
            panelTrangchu.Location = new Point(311, 44);
            panelTrangchu.Margin = new Padding(3, 4, 3, 4);
            panelTrangchu.Name = "panelTrangchu";
            panelTrangchu.Size = new Size(1230, 83);
            panelTrangchu.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(845, 20);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(371, 55);
            button1.TabIndex = 1;
            button1.Text = "Nhân Viên";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrangChu.ForeColor = Color.FromArgb(218, 165, 32);
            btnTrangChu.Image = (Image)resources.GetObject("btnTrangChu.Image");
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(27, 9);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(223, 75);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // panelChinh
            // 
            panelChinh.BackColor = Color.FromArgb(255, 228, 196);
            panelChinh.Dock = DockStyle.Fill;
            panelChinh.Location = new Point(311, 127);
            panelChinh.Margin = new Padding(3, 4, 3, 4);
            panelChinh.Name = "panelChinh";
            panelChinh.Size = new Size(1230, 1029);
            panelChinh.TabIndex = 4;
            panelChinh.Paint += panelChinh_Paint;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 196);
            ClientSize = new Size(1541, 1156);
            Controls.Add(panelChinh);
            Controls.Add(panelTrangchu);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelsubmenuHeThong.ResumeLayout(false);
            panelsubmenuGiaiTri.ResumeLayout(false);
            panelsubmenuThietLap.ResumeLayout(false);
            panelsubmenuBaoCao.ResumeLayout(false);
            panelsubmenuHoatDong.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTrangchu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnHoatDong;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panelTrangchu;
        private Panel panelChinh;
        private Button btnTrangChu;
        private Panel panelsubmenuHoatDong;
        private Button btnHoaDon;
        private Button btnDattphong;
        private Button btnDatHang;
        private Button btnNhapXuatKho;
        private Button btnBaoCao;
        private Panel panelsubmenuBaoCao;
        private Button btnThongKe;
        private Button btnDoanhThu;
        private Button btnThietLap;
        private Panel panelsubmenuThietLap;
        private Button btninforNhanVien;
        private Button btnKhachhang;
        private Button btnPhong;
        private Button btnMonAn;
        private Button btnHeThong;
        private Panel panelsubmenuHeThong;
        private Button btnCaiDat;
        private Button btnDangXuat;
        private Button button1;
        private Label lblUserInfo;
        private Panel panelsubmenuGiaiTri;
        private Button btnSudoku;
        private Button btnGiaiTri;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}