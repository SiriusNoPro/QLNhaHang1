namespace DOAN
{
    partial class ThongtinNhanVien
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
            txt_MaNV = new TextBox();
            lbt_MaNV = new Label();
            lbt_HoTen = new Label();
            lbt_GioiTinh = new Label();
            lbt_Chucvu = new Label();
            comboBox_GioiTinh = new ComboBox();
            lbt_Sodt = new Label();
            lbt_Email = new Label();
            lbt_Diachi = new Label();
            lbt_Taikhoan = new Label();
            lbt_Matkhau = new Label();
            txt_HoTen = new TextBox();
            txt_Taikhoan = new TextBox();
            txt_MatKhau = new TextBox();
            comboBox_ChucVu = new ComboBox();
            txt_SoDT = new TextBox();
            txt_Email = new TextBox();
            label1 = new Label();
            dateTimePicker_NS = new DateTimePicker();
            txt_DiaChi = new TextBox();
            pictureBox1 = new PictureBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            btn_Luu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_MaNV
            // 
            txt_MaNV.Font = new Font("Times New Roman", 10.8F);
            txt_MaNV.Location = new Point(200, 70);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(272, 28);
            txt_MaNV.TabIndex = 0;
            // 
            // lbt_MaNV
            // 
            lbt_MaNV.AutoSize = true;
            lbt_MaNV.Font = new Font("Times New Roman", 10.8F);
            lbt_MaNV.Location = new Point(70, 77);
            lbt_MaNV.Name = "lbt_MaNV";
            lbt_MaNV.Size = new Size(117, 20);
            lbt_MaNV.TabIndex = 1;
            lbt_MaNV.Text = "Mã nhân viên: ";
            lbt_MaNV.Click += label1_Click;
            // 
            // lbt_HoTen
            // 
            lbt_HoTen.AutoSize = true;
            lbt_HoTen.Font = new Font("Times New Roman", 10.8F);
            lbt_HoTen.Location = new Point(70, 110);
            lbt_HoTen.Name = "lbt_HoTen";
            lbt_HoTen.Size = new Size(99, 20);
            lbt_HoTen.TabIndex = 2;
            lbt_HoTen.Text = "Họ Và Tên: ";
            // 
            // lbt_GioiTinh
            // 
            lbt_GioiTinh.AutoSize = true;
            lbt_GioiTinh.Font = new Font("Times New Roman", 10.8F);
            lbt_GioiTinh.Location = new Point(70, 243);
            lbt_GioiTinh.Name = "lbt_GioiTinh";
            lbt_GioiTinh.Size = new Size(82, 20);
            lbt_GioiTinh.TabIndex = 3;
            lbt_GioiTinh.Text = "Giới tính: ";
            // 
            // lbt_Chucvu
            // 
            lbt_Chucvu.AutoSize = true;
            lbt_Chucvu.Font = new Font("Times New Roman", 10.8F);
            lbt_Chucvu.Location = new Point(70, 277);
            lbt_Chucvu.Name = "lbt_Chucvu";
            lbt_Chucvu.Size = new Size(80, 20);
            lbt_Chucvu.TabIndex = 4;
            lbt_Chucvu.Text = "Chức vụ: ";
            // 
            // comboBox_GioiTinh
            // 
            comboBox_GioiTinh.Font = new Font("Times New Roman", 10.8F);
            comboBox_GioiTinh.FormattingEnabled = true;
            comboBox_GioiTinh.Location = new Point(200, 235);
            comboBox_GioiTinh.Name = "comboBox_GioiTinh";
            comboBox_GioiTinh.Size = new Size(272, 28);
            comboBox_GioiTinh.TabIndex = 5;
            // 
            // lbt_Sodt
            // 
            lbt_Sodt.AutoSize = true;
            lbt_Sodt.Font = new Font("Times New Roman", 10.8F);
            lbt_Sodt.Location = new Point(70, 310);
            lbt_Sodt.Name = "lbt_Sodt";
            lbt_Sodt.Size = new Size(112, 20);
            lbt_Sodt.TabIndex = 6;
            lbt_Sodt.Text = "Số điện thoại: ";
            // 
            // lbt_Email
            // 
            lbt_Email.AutoSize = true;
            lbt_Email.Font = new Font("Times New Roman", 10.8F);
            lbt_Email.Location = new Point(70, 343);
            lbt_Email.Name = "lbt_Email";
            lbt_Email.Size = new Size(59, 20);
            lbt_Email.TabIndex = 7;
            lbt_Email.Text = "Email: ";
            // 
            // lbt_Diachi
            // 
            lbt_Diachi.AutoSize = true;
            lbt_Diachi.Font = new Font("Times New Roman", 10.8F);
            lbt_Diachi.Location = new Point(70, 376);
            lbt_Diachi.Name = "lbt_Diachi";
            lbt_Diachi.Size = new Size(69, 20);
            lbt_Diachi.TabIndex = 8;
            lbt_Diachi.Text = "Địa chỉ: ";
            lbt_Diachi.Click += lbt_Diachi_Click;
            // 
            // lbt_Taikhoan
            // 
            lbt_Taikhoan.AutoSize = true;
            lbt_Taikhoan.Font = new Font("Times New Roman", 10.8F);
            lbt_Taikhoan.Location = new Point(70, 176);
            lbt_Taikhoan.Name = "lbt_Taikhoan";
            lbt_Taikhoan.Size = new Size(91, 20);
            lbt_Taikhoan.TabIndex = 9;
            lbt_Taikhoan.Text = "Tài khoản: ";
            // 
            // lbt_Matkhau
            // 
            lbt_Matkhau.AutoSize = true;
            lbt_Matkhau.Font = new Font("Times New Roman", 10.8F);
            lbt_Matkhau.Location = new Point(70, 209);
            lbt_Matkhau.Name = "lbt_Matkhau";
            lbt_Matkhau.Size = new Size(87, 20);
            lbt_Matkhau.TabIndex = 10;
            lbt_Matkhau.Text = "Mật khẩu: ";
            // 
            // txt_HoTen
            // 
            txt_HoTen.Font = new Font("Times New Roman", 10.8F);
            txt_HoTen.Location = new Point(200, 103);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(272, 28);
            txt_HoTen.TabIndex = 11;
            // 
            // txt_Taikhoan
            // 
            txt_Taikhoan.Font = new Font("Times New Roman", 10.8F);
            txt_Taikhoan.Location = new Point(200, 169);
            txt_Taikhoan.Name = "txt_Taikhoan";
            txt_Taikhoan.Size = new Size(272, 28);
            txt_Taikhoan.TabIndex = 12;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Font = new Font("Times New Roman", 10.8F);
            txt_MatKhau.Location = new Point(200, 202);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(272, 28);
            txt_MatKhau.TabIndex = 13;
            txt_MatKhau.TextChanged += textBox4_TextChanged;
            // 
            // comboBox_ChucVu
            // 
            comboBox_ChucVu.Font = new Font("Times New Roman", 10.8F);
            comboBox_ChucVu.FormattingEnabled = true;
            comboBox_ChucVu.Location = new Point(200, 269);
            comboBox_ChucVu.Name = "comboBox_ChucVu";
            comboBox_ChucVu.Size = new Size(272, 28);
            comboBox_ChucVu.TabIndex = 14;
            // 
            // txt_SoDT
            // 
            txt_SoDT.Font = new Font("Times New Roman", 10.8F);
            txt_SoDT.Location = new Point(200, 303);
            txt_SoDT.Name = "txt_SoDT";
            txt_SoDT.Size = new Size(272, 28);
            txt_SoDT.TabIndex = 15;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Times New Roman", 10.8F);
            txt_Email.Location = new Point(200, 336);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(272, 28);
            txt_Email.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F);
            label1.Location = new Point(70, 143);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 17;
            label1.Text = "Ngày sinh: ";
            // 
            // dateTimePicker_NS
            // 
            dateTimePicker_NS.Font = new Font("Times New Roman", 10.8F);
            dateTimePicker_NS.Location = new Point(200, 136);
            dateTimePicker_NS.Name = "dateTimePicker_NS";
            dateTimePicker_NS.Size = new Size(272, 28);
            dateTimePicker_NS.TabIndex = 18;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Font = new Font("Times New Roman", 10.8F);
            txt_DiaChi.Location = new Point(200, 369);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(272, 28);
            txt_DiaChi.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(714, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 164);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Them.Location = new Point(129, 420);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(112, 35);
            btn_Them.TabIndex = 21;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Sua.Location = new Point(305, 420);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(112, 35);
            btn_Sua.TabIndex = 22;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Xoa.Location = new Point(484, 420);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(112, 35);
            btn_Xoa.TabIndex = 23;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 473);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(847, 188);
            dataGridView1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(200, 9);
            label2.Name = "label2";
            label2.Size = new Size(533, 51);
            label2.TabIndex = 25;
            label2.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btn_Luu
            // 
            btn_Luu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_Luu.Location = new Point(674, 420);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(112, 35);
            btn_Luu.TabIndex = 26;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            // 
            // ThongtinNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 673);
            Controls.Add(btn_Luu);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(pictureBox1);
            Controls.Add(txt_DiaChi);
            Controls.Add(dateTimePicker_NS);
            Controls.Add(label1);
            Controls.Add(txt_Email);
            Controls.Add(txt_SoDT);
            Controls.Add(comboBox_ChucVu);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_Taikhoan);
            Controls.Add(txt_HoTen);
            Controls.Add(lbt_Matkhau);
            Controls.Add(lbt_Taikhoan);
            Controls.Add(lbt_Diachi);
            Controls.Add(lbt_Email);
            Controls.Add(lbt_Sodt);
            Controls.Add(comboBox_GioiTinh);
            Controls.Add(lbt_Chucvu);
            Controls.Add(lbt_GioiTinh);
            Controls.Add(lbt_HoTen);
            Controls.Add(lbt_MaNV);
            Controls.Add(txt_MaNV);
            Name = "ThongtinNhanVien";
            Text = "ThongtinNhanVien";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_MaNV;
        private Label lbt_MaNV;
        private Label lbt_HoTen;
        private Label lbt_GioiTinh;
        private Label lbt_Chucvu;
        private ComboBox comboBox_GioiTinh;
        private Label lbt_Sodt;
        private Label lbt_Email;
        private Label lbt_Diachi;
        private Label lbt_Taikhoan;
        private Label lbt_Matkhau;
        private TextBox txt_HoTen;
        private TextBox txt_Taikhoan;
        private TextBox txt_MatKhau;
        private ComboBox comboBox_ChucVu;
        private TextBox txt_SoDT;
        private TextBox txt_Email;
        private Label label1;
        private DateTimePicker dateTimePicker_NS;
        private TextBox txt_DiaChi;
        private PictureBox pictureBox1;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btn_Luu;
    }
}