using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaHang.BUS;
using QLNhaHang.DTO;

namespace FormDangNhap
{
    public partial class frmDangNhap : Form
    {
        private int loginAttempts = 0;
        private const int MAX_LOGIN_ATTEMPTS = 3;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            login1.Focus();
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = login1.textBox1.Text;
            string password = login2.textBox1.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVienDTO nhanVien = NhanVienBUS.Instance.DangNhap(username, password);

            if (nhanVien != null)
            {
                GlobalState.CurrentUser = nhanVien;
                MessageBox.Show($"Đăng nhập thành công! Chào mừng {nhanVien.HoTen}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                loginAttempts++;
                if (loginAttempts >= MAX_LOGIN_ATTEMPTS)
                {
                    MessageBox.Show("Bạn đã nhập sai thông tin đăng nhập quá 3 lần. Chương trình sẽ tự động tắt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Sai tài khoản hoặc mật khẩu! Bạn còn {MAX_LOGIN_ATTEMPTS - loginAttempts} lần thử.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login2.textBox1.UseSystemPasswordChar = !checkBox1.Checked;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản lý để lấy lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

