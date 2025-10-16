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
using QLNhaHang.DAO;
namespace DOAN
{
    public partial class ThongtinNhanVien : Form
    {
        private readonly NhanVienBUS nhanVienBUS = NhanVienBUS.Instance;
        private DatabaseHelper db = new DatabaseHelper();
        public ThongtinNhanVien()
        {
            InitializeComponent();
            Load += ThongtinNhanVien_Load;
            comboBox_GioiTinh.Items.Clear();
            comboBox_GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            btn_Them.Click += Btn_Them_Click;
            btn_Sua.Click += Btn_Sua_Click;
            btn_Xoa.Click += Btn_Xoa_Click;
            btn_Luu.Click += Btn_Luu_Click;
            load_data();

        }
        private void load_data()
        {
            string conect = "SELECT * FROM NhanVien";
            NhanVienDAO nv = new NhanVienDAO();
            List<NhanVienDTO> dt = nv.LayTatCa();
            dataGridView1.DataSource = dt;
            if (dataGridView1.Columns.Contains("HinhAnh"))
            {
                dataGridView1.Columns["HinhAnh"].Visible = false;
            }
            dataGridView1.Columns["MaNV"].HeaderText = "Mã NV";
            dataGridView1.Columns["HoTen"].HeaderText = "Tên NV";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridView1.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["TaiKhoan"].HeaderText = "Tài Khoản";
            dataGridView1.Columns["MatKhau"].HeaderText = "Mật Khẩu";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbt_Diachi_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThongtinNhanVien_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var list = nhanVienBUS.LayTatCa();
            dataGridView1.DataSource = list;
        }

        private NhanVienDTO ReadForm()
        {
            return new NhanVienDTO
            {
                MaNV = txt_MaNV.Text?.Trim(),
                HoTen = txt_HoTen.Text?.Trim(),
                GioiTinh = comboBox_GioiTinh.SelectedItem?.ToString(),
                ChucVu = comboBox_ChucVu.SelectedItem?.ToString() ?? comboBox_ChucVu.Text?.Trim(),
                SoDienThoai = txt_SoDT.Text?.Trim(),
                Email = txt_Email.Text?.Trim(),
                DiaChi = txt_DiaChi.Text?.Trim(),
                TaiKhoan = txt_Taikhoan.Text?.Trim(),
                MatKhau = txt_MatKhau.Text
            };
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            var dto = ReadForm();
            if (!nhanVienBUS.Them(dto))
            {
                MessageBox.Show("Thêm nhân viên thất bại. Vui lòng kiểm tra dữ liệu.");
                return;
            }
            RefreshGrid();
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            var dto = ReadForm();
            if (!nhanVienBUS.CapNhat(dto))
            {
                MessageBox.Show("Cập nhật thất bại.");
                return;
            }
            RefreshGrid();
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            var ma = txt_MaNV.Text?.Trim();
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Vui lòng nhập Mã NV để xóa.");
                return;
            }
            if (!nhanVienBUS.Xoa(ma))
            {
                MessageBox.Show("Xóa thất bại.");
                return;
            }
            RefreshGrid();
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            var dto = ReadForm();
            var updated = nhanVienBUS.CapNhat(dto);
            if (!updated)
            {
                if (!nhanVienBUS.Them(dto))
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }
            }
            RefreshGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_MaNV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value?.ToString();
                txt_HoTen.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value?.ToString();
                txt_SoDT.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoai"].Value?.ToString();
                dateTimePicker_NS.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
                txt_DiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value?.ToString();
                txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
                txt_Taikhoan.Text = dataGridView1.Rows[e.RowIndex].Cells["TaiKhoan"].Value?.ToString();
                txt_MatKhau.Text = dataGridView1.Rows[e.RowIndex].Cells["MatKhau"].Value?.ToString();
                comboBox_GioiTinh.Text = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value?.ToString();
                comboBox_ChucVu.Text = dataGridView1.Rows[e.RowIndex].Cells["ChucVu"].Value?.ToString();
            }
        }
    }
}
