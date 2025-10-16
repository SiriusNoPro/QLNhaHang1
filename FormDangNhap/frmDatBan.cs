using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLNhaHang.BUS;
using QLNhaHang.DTO;

namespace DOAN
{
    public partial class frmDatBan : Form
    {
        private readonly DatBanBUS datBanBUS = new DatBanBUS();
        private readonly BanNhaHangBUS banBUS = new BanNhaHangBUS();

        private readonly BindingSource bsBan = new BindingSource();
        private readonly BindingSource bsDat = new BindingSource();

        public frmDatBan()
        {
            InitializeComponent();
        }

        private void frmDatBan_Load(object sender, EventArgs e)
        {
            LoadBans();
            LoadBookingsForToday();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackColor = Color.FromArgb(255, 228, 196);
            panelLeft.BackColor = Color.White;
            panelRight.BackColor = Color.White;
        }

        private void LoadBans()
        {
            var ds = banBUS.LayTatCa();
            bsBan.DataSource = ds;
            cboBan.DataSource = ds.ToList();
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "MaBan";
        }

        private void LoadBookingsForToday()
        {
            var ds = datBanBUS.LayTatCa().Where(d => d.ThoiGianDat.Date == DateTime.Today).OrderBy(d => d.ThoiGianDat).ToList();
            bsDat.DataSource = ds;
            gridDatBan.DataSource = bsDat;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            var ma = $"DB{DateTime.Now:yyyyMMddHHmmss}";
            var dto = new DatBanDTO
            {
                MaDatBan = ma,
                MaKH = txtMaKH.Text,
                MaBan = cboBan.SelectedValue as string,
                ThoiGianDat = dtpThoiGian.Value,
                SoLuongKhach = (int)numSoLuong.Value,
                YeuCau = txtYeuCau.Text,
                TrangThai = "DaDatTruoc"
            };

            // default duration 120 minutes for overlap check
            if (!datBanBUS.KiemTraBanRanh(dto.MaBan, dto.ThoiGianDat, TimeSpan.FromMinutes(120)))
            {
                MessageBox.Show("Bàn không rảnh trong thời gian yêu cầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (datBanBUS.DatBanVaCapNhatTrangThai(dto))
            {
                LoadBookingsForToday();
                MessageBox.Show("Đặt bàn thành công");
            }
            else
            {
                MessageBox.Show("Đặt bàn thất bại");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (gridDatBan.CurrentRow == null) return;
            var dto = (DatBanDTO)gridDatBan.CurrentRow.DataBoundItem;
            dto.MaKH = txtMaKH.Text;
            dto.MaBan = cboBan.SelectedValue as string;
            dto.ThoiGianDat = dtpThoiGian.Value;
            dto.SoLuongKhach = (int)numSoLuong.Value;
            dto.YeuCau = txtYeuCau.Text;
            if (!datBanBUS.KiemTraBanRanh(dto.MaBan, dto.ThoiGianDat, TimeSpan.FromMinutes(120)))
            {
                MessageBox.Show("Bàn không rảnh trong thời gian yêu cầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (datBanBUS.CapNhat(dto))
            {
                LoadBookingsForToday();
                MessageBox.Show("Cập nhật thành công");
            }
            else MessageBox.Show("Cập nhật thất bại");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (gridDatBan.CurrentRow == null) return;
            var dto = (DatBanDTO)gridDatBan.CurrentRow.DataBoundItem;
            if (datBanBUS.Xoa(dto.MaDatBan))
            {
                datBanBUS.ChuyenVeTrong(dto.MaBan);
                LoadBookingsForToday();
                MessageBox.Show("Đã hủy đặt bàn và chuyển trạng thái bàn về Trống");
            }
            else MessageBox.Show("Hủy thất bại");
        }

        private void gridDatBan_SelectionChanged(object sender, EventArgs e)
        {
            if (gridDatBan.CurrentRow == null) return;
            var dto = (DatBanDTO)gridDatBan.CurrentRow.DataBoundItem;
            txtMaKH.Text = dto.MaKH;
            cboBan.SelectedValue = dto.MaBan;
            dtpThoiGian.Value = dto.ThoiGianDat;
            numSoLuong.Value = dto.SoLuongKhach ?? 0;
            txtYeuCau.Text = dto.YeuCau;
        }
    }
}


