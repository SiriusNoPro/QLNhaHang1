using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QLNhaHang.BUS;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace DOAN
{
    public partial class frmDatHang : Form
    {
        private readonly DatBanBUS datBanBUS = new DatBanBUS();
        private readonly BanNhaHangBUS banBUS = new BanNhaHangBUS();
        private readonly LoaiMatHangBUS loaiMatHangBUS = new LoaiMatHangBUS();
        private readonly MatHangBUS matHangBUS = new MatHangBUS();
        private readonly GoiMonBUS goiMonBUS = new GoiMonBUS();
        private readonly GoiMonChiTietBUS chiTietBUS = new GoiMonChiTietBUS();

        private readonly BindingSource bsLoai = new BindingSource();
        private readonly BindingSource bsMon = new BindingSource();
        private readonly BindingSource bsDatBan = new BindingSource();
        private readonly BindingSource bsGio = new BindingSource();

        private readonly Dictionary<string, (MatHangDTO item, int qty)> cart = new Dictionary<string, (MatHangDTO, int)>();

        public frmDatHang()
        {
            InitializeComponent();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            LoadSources();
            ApplyTheme();
        }

        private void LoadSources()
        {
            var dsLoai = loaiMatHangBUS.LayTatCa();
            var dsMon = matHangBUS.LayTatCa().OrderBy(m=>m.MaMH).ToList();
            var dsDat = datBanBUS.LayTatCa();

            bsLoai.DataSource = dsLoai;
            listLoai.DataSource = bsLoai;
            listLoai.DisplayMember = "TenLoaiMH";
            listLoai.ValueMember = "MaLoaiMH";

            bsMon.DataSource = dsMon;
            RenderMenuTiles(dsMon);

            bsDatBan.DataSource = dsDat;
            cboDatBan.DataSource = bsDatBan;
            cboDatBan.DisplayMember = "MaDatBan";
            cboDatBan.ValueMember = "MaDatBan";

            bsGio.DataSource = new List<dynamic>();
            gridGio.AutoGenerateColumns = false;
            gridGio.DataSource = bsGio;
        }

        private void ApplyTheme()
        {
            BackColor = Color.FromArgb(255, 228, 196);
            panelLeft.BackColor = Color.White;
            panelRight.BackColor = Color.White;
            panelHeader.BackColor = Color.White;
            lblTitle.ForeColor = Color.FromArgb(74, 44, 44);
            btnDatHang.BackColor = Color.FromArgb(218, 165, 32);
            btnDatHang.ForeColor = Color.White;
            btnXoaMon.BackColor = Color.FromArgb(199, 80, 80);
            btnXoaMon.ForeColor = Color.White;
            btnXoaGio.BackColor = Color.FromArgb(105, 105, 105);
            btnXoaGio.ForeColor = Color.White;
        }

        private void listLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maLoai = listLoai.SelectedValue as string;
            if (string.IsNullOrEmpty(maLoai)) return;
            var dsMon = matHangBUS.LayTatCa().Where(m => m.MaLoaiMH == maLoai).ToList();
            bsMon.DataSource = dsMon;
            RenderMenuTiles(dsMon);
        }

        private void RenderMenuTiles(IEnumerable<MatHangDTO> items)
        {
            flowMenu.SuspendLayout();
            flowMenu.AutoScroll = true;                          
            flowMenu.WrapContents = true;                        
            flowMenu.FlowDirection = FlowDirection.LeftToRight; 

            flowMenu.Controls.Clear();
            foreach (var m in items)
            {
                var card = BuildMenuCard(m);
                flowMenu.Controls.Add(card);
            }
            flowMenu.ResumeLayout();
        }
        public void LoadMonAnImage(string maMon, PictureBox pictureBox)
        {

            string query = "SELECT HinhAnh FROM MatHang WHERE MaMH = @MaMH";
            var parameters = new Dictionary<string, object>()
            {
                    {"@MaMH", maMon } 
            };

            object result = DatabaseHelper.ExecuteScalar(query, parameters);
            string tenAnh = result != null && result != DBNull.Value ? result.ToString() : null;

            if (!string.IsNullOrEmpty(tenAnh))
            { 
                string imagePath = Path.Combine("Picture", tenAnh);

                pictureBox.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
            }
            else
            {
                pictureBox.Image = null;
            }

        }

        private Control BuildMenuCard(MatHangDTO mon)
        {
            var panel = new Panel
            {
                Width = 170,
                Height = 190,
                Margin = new Padding(8),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            var pic = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 120,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White
            };
            try
            {
                LoadMonAnImage(mon.MaMH, pic);
                
            }
            catch {
                pic.Image = null;
            }
          

            var lblTen = new Label
            {
                Dock = DockStyle.Top,
                Text = mon.TenMH,
                Height = 34,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblGia = new Label
            {
                Dock = DockStyle.Top,
                Text = mon.Gia.ToString("#,##0"),
                ForeColor = Color.FromArgb(74, 44, 44),
                Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold),
                Height = 22,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var btn = new Button
            {
                Text = "+",
                Dock = DockStyle.Bottom,
                Height = 26
            };
            btn.Click += (s, e) => ThemVaoGio(mon, 1);

            panel.Controls.Add(btn);
            panel.Controls.Add(lblGia);
            panel.Controls.Add(lblTen);
            panel.Controls.Add(pic);
            return panel;
        }

        private void ThemVaoGio(MatHangDTO mon, int soLuong)
        {
            if (mon == null || soLuong <= 0) return;
            if (cart.ContainsKey(mon.MaMH))
            {
                var current = cart[mon.MaMH];
                cart[mon.MaMH] = (current.item, current.qty + soLuong);
            }
            else
            {
                cart[mon.MaMH] = (mon, soLuong);
            }
            RefreshCart();
        }

        private void RefreshCart()
        {
            var view = cart.Values.Select(v => new
            {
                MaMH = v.item.MaMH,
                TenMH = v.item.TenMH,
                SoLuong = v.qty,
                DonGia = v.item.Gia,
                ThanhTien = v.item.Gia * v.qty
            }).ToList();
            bsGio.DataSource = view;
            bsGio.ResetBindings(false);
            lblTongTien.Text = view.Sum(x => x.ThanhTien).ToString("#,##0");
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (gridGio.CurrentRow == null) return;
            var ma = gridGio.CurrentRow.Cells["colMaMH"].Value?.ToString();
            if (string.IsNullOrEmpty(ma)) return;
            cart.Remove(ma);
            RefreshCart();
        }

        private void btnXoaGio_Click(object sender, EventArgs e)
        {
            cart.Clear();
            RefreshCart();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Chưa có món trong giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var maDatBan = cboDatBan.SelectedValue as string;
            if (string.IsNullOrWhiteSpace(maDatBan))
            {
                MessageBox.Show("Vui lòng chọn đặt bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var maGoiMon = $"GM{DateTime.Now:yyyyMMddHHmmssfff}";
            var goi = new GoiMonDTO
            {
                MaGoiMon = maGoiMon,
                MaDatBan = maDatBan,
                MaNVGoi = null,
                ThoiGianGoi = DateTime.Now,
                TrangThai = "MOI",
                GhiChu = txtGhiChu.Text
            };
            if (!goiMonBUS.Them(goi))
            {
                MessageBox.Show("Không thể tạo phiếu gọi món", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var kv in cart)
            {
                var ct = new GoiMonChiTietDTO
                {
                    MaGoiMonCT = $"CT{Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper()}",
                    MaGoiMon = maGoiMon,
                    MaMH = kv.Value.item.MaMH,
                    SoLuong = kv.Value.qty,
                    GiaTaiThoiDiem = DateTime.Now,
                    TrangThai = "CHO_BEP",
                    MaNVBep = null,
                    ThoiGianTrangThai = null,
                    GhiChu = null
                };
                if (!chiTietBUS.Them(ct))
                {
                    MessageBox.Show($"Lỗi thêm chi tiết cho món {kv.Value.item.TenMH}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Đặt hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cart.Clear();
            RefreshCart();
        }
    }
}


