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
using System.Data;

namespace DOAN
{
    public partial class ThongTinKH : Form
    {
        private readonly KhachHangBUS khachHangBUS = new KhachHangBUS();
        public ThongTinKH()
        {
            InitializeComponent();
            Load += ThongTinKH_Load;
            comboBox_GioiTinhKH.Items.Clear();
            comboBox_GioiTinhKH.Items.AddRange(new object[] { "Nam", "Nữ" });
            btn_ThemKH.Click += Btn_ThemKH_Click;
            btn_SuaKH.Click += Btn_SuaKH_Click;
            btn_XoaKH.Click += Btn_XoaKH_Click;
            btn_LuuKH.Click += Btn_LuuKH_Click;
        }

        private void ThongTinKH_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var list = khachHangBUS.LayTatCa();
            dataGridView1.DataSource = list;
        }

        private KhachHangDTO ReadForm()
        {
            return new KhachHangDTO
            {
                MaKH = txt_MaKH.Text?.Trim(),
                TenKH = txt_HoTenKH.Text?.Trim(),
                GioiTinh = comboBox_GioiTinhKH.SelectedItem?.ToString(),
                SDT = txt_SoDTKH.Text?.Trim(),
                Email = txt_EmailKH.Text?.Trim(),
                DiaChi = txt_DiaChiKh.Text?.Trim(),
                DiemTichLuy = int.TryParse(txt_Diemtichluy.Text, out var d) ? d : 0
            };
        }

        private void Btn_ThemKH_Click(object sender, EventArgs e)
        {
            var dto = ReadForm();
            if (!khachHangBUS.Them(dto))
            {
                MessageBox.Show("Thêm khách hàng thất bại. Vui lòng kiểm tra dữ liệu.");
                return;
            }
            RefreshGrid();
        }

        private void Btn_SuaKH_Click(object sender, EventArgs e)
        {
            var dto = ReadForm();
            if (!khachHangBUS.CapNhat(dto))
            {
                MessageBox.Show("Cập nhật thất bại.");
                return;
            }
            RefreshGrid();
        }

        private void Btn_XoaKH_Click(object sender, EventArgs e)
        {
            var ma = txt_MaKH.Text?.Trim();
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Vui lòng nhập Mã KH để xóa.");
                return;
            }
            if (!khachHangBUS.Xoa(ma))
            {
                MessageBox.Show("Xóa thất bại.");
                return;
            }
            RefreshGrid();
        }

        private void Btn_LuuKH_Click(object sender, EventArgs e)
        {
            // Lưu = nếu tồn tại thì cập nhật, không thì thêm
            var dto = ReadForm();
            var updated = khachHangBUS.CapNhat(dto);
            if (!updated)
            {
                if (!khachHangBUS.Them(dto))
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }
            }
            RefreshGrid();
        }

        private void btn_LuuKH_Click_1(object sender, EventArgs e)
        {

        }
    }
}
