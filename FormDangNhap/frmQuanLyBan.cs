using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLNhaHang.BUS;
using QLNhaHang.DTO;

namespace DOAN
{
    public partial class frmQuanLyBan : Form
    {
        private readonly LoaiBanBUS loaiBanBUS = new LoaiBanBUS();
        private readonly BanNhaHangBUS banBUS = new BanNhaHangBUS();

        private readonly BindingSource bsLoai = new BindingSource();
        private readonly BindingSource bsBan = new BindingSource();

        public frmQuanLyBan()
        {
            InitializeComponent();
        }

        private void frmQuanLyBan_Load(object sender, EventArgs e)
        {
            LoadLoaiBan();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackColor = Color.FromArgb(255, 228, 196);
            panelLeft.BackColor = Color.White;
            panelRight.BackColor = Color.White;
        }

        private void LoadLoaiBan()
        {
            var ds = loaiBanBUS.LayTatCa();
            bsLoai.DataSource = ds;
            gridLoai.DataSource = bsLoai;
            cboLoaiBan.DataSource = ds.ToList();
            cboLoaiBan.DisplayMember = "TenLoaiBan";
            cboLoaiBan.ValueMember = "MaLoaiBan";
            LoadBanTheoLoai();
        }

        private void LoadBanTheoLoai()
        {
            var ma = cboLoaiBan.SelectedValue as string;
            var ds = banBUS.LayTatCa();
            if (!string.IsNullOrEmpty(ma))
                ds = ds.Where(x => x.MaLoaiBan == ma).ToList();
            bsBan.DataSource = ds;
            gridBan.DataSource = bsBan;
        }

        private void btnLoaiThem_Click(object sender, EventArgs e)
        {
            var dto = new LoaiBanDTO { MaLoaiBan = txtMaLoai.Text, TenLoaiBan = txtTenLoai.Text };
            if (loaiBanBUS.Them(dto)) LoadLoaiBan(); else MessageBox.Show("Thêm loại bàn thất bại");
        }

        private void btnLoaiSua_Click(object sender, EventArgs e)
        {
            var dto = new LoaiBanDTO { MaLoaiBan = txtMaLoai.Text, TenLoaiBan = txtTenLoai.Text };
            if (loaiBanBUS.CapNhat(dto)) LoadLoaiBan(); else MessageBox.Show("Cập nhật loại bàn thất bại");
        }

        private void btnLoaiXoa_Click(object sender, EventArgs e)
        {
            if (loaiBanBUS.Xoa(txtMaLoai.Text)) LoadLoaiBan(); else MessageBox.Show("Xóa loại bàn thất bại");
        }

        private void btnBanThem_Click(object sender, EventArgs e)
        {
            var dto = new BanNhaHangDTO
            {
                MaBan = txtMaBan.Text,
                TenBan = txtTenBan.Text,
                MaLoaiBan = cboLoaiBan.SelectedValue as string,
                SoLuongKhach = (int)numMax.Value,
                TrangThai = cboTrangThai.Text
            };
            if (banBUS.Them(dto)) LoadBanTheoLoai(); else MessageBox.Show("Thêm bàn thất bại");
        }

        private void btnBanSua_Click(object sender, EventArgs e)
        {
            var dto = new BanNhaHangDTO
            {
                MaBan = txtMaBan.Text,
                TenBan = txtTenBan.Text,
                MaLoaiBan = cboLoaiBan.SelectedValue as string,
                SoLuongKhach = (int)numMax.Value,
                TrangThai = cboTrangThai.Text
            };
            if (banBUS.CapNhat(dto)) LoadBanTheoLoai(); else MessageBox.Show("Cập nhật bàn thất bại");
        }

        private void btnBanXoa_Click(object sender, EventArgs e)
        {
            if (banBUS.Xoa(txtMaBan.Text)) LoadBanTheoLoai(); else MessageBox.Show("Xóa bàn thất bại");
        }

        private void gridLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (gridLoai.CurrentRow == null) return;
            var row = gridLoai.CurrentRow.DataBoundItem as LoaiBanDTO;
            if (row == null) return;
            txtMaLoai.Text = row.MaLoaiBan;
            txtTenLoai.Text = row.TenLoaiBan;
            cboLoaiBan.SelectedValue = row.MaLoaiBan;
            LoadBanTheoLoai();
        }

        private void gridBan_SelectionChanged(object sender, EventArgs e)
        {
            if (gridBan.CurrentRow == null) return;
            var row = gridBan.CurrentRow.DataBoundItem as BanNhaHangDTO;
            if (row == null) return;
            txtMaBan.Text = row.MaBan;
            txtTenBan.Text = row.TenBan;
            cboTrangThai.Text = row.TrangThai;
            numMax.Value = row.SoLuongKhach ?? 0;
        }
    }
}


