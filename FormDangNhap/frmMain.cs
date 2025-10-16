using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using FormDangNhap;
using QLNhaHang.BUS;
using QLNhaHang.DTO;

namespace DOAN
{
    public partial class frmMain : Form
    {
        private string currentUserMaNV = "NV001"; 
        
        public frmMain()
        {
            InitializeComponent();
            customizeDesing();
            //UpdateLoginStatus();
        }

        //private void UpdateLoginStatus()
        //{
        //    if (GlobalState.IsLoggedIn)
        //    {
        //        lblUserInfo.Text = $"Xin chào, {GlobalState.CurrentUser.ChucVu} {GlobalState.CurrentUser.HoTen}";
        //        lblUserInfo.Visible = true;
        //        button1.Text = $"Xin chào, {GlobalState.CurrentUser.ChucVu} {GlobalState.CurrentUser.HoTen}";
        //        currentUserMaNV = GlobalState.CurrentUser.MaNV;
        //    }
        //    else
        //    {
        //        lblUserInfo.Text = "Chưa đăng nhập";
        //        lblUserInfo.Visible = true;
        //        button1.Text = "User";
        //        currentUserMaNV = "NV001"; 
        //    }
        //}
        //private bool CheckLoginRequired()
        //{
        //    if (!GlobalState.IsLoggedIn)
        //    {
        //        MessageBox.Show("Bạn chưa đăng nhập! Vui lòng đăng nhập để sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    return true;
        //}
        //private bool CheckManagerAccess()
        //{
        //    if (!GlobalState.IsLoggedIn)
        //    {
        //        return false;
        //    }

        //    if (GlobalState.CurrentUser.ChucVu != "Quản lý")
        //    {
        //        MessageBox.Show("Chỉ có Quản lý mới được phép truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }
        //    return true;
        //}

        //private bool CheckAccess(bool requiresManagerAccess)
        //{
        //    if (!CheckLoginRequired())
        //        return false;

        //    if (requiresManagerAccess && !CheckManagerAccess())
        //        return false;

        //    return true;
        //}

        //[DllImport("user32.dll")]
        //public static extern bool ReleaseCapture();

        //[DllImport("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HTCAPTION = 0x2;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    ReleaseCapture();
            //    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            //}
        }
        private void customizeDesing()
        {
            panelsubmenuHoatDong.Visible = false;
            panelsubmenuBaoCao.Visible = false;
            panelsubmenuThietLap.Visible = false;
            panelsubmenuHeThong.Visible = false;
            panelsubmenuGiaiTri.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelsubmenuHoatDong.Visible == true)
            {
                panelsubmenuHoatDong.Visible = false;
            }
            if (panelsubmenuHeThong.Visible == true)
            {
                panelsubmenuHeThong.Visible = false;
            }
            if (panelsubmenuThietLap.Visible == true)
            {
                panelsubmenuThietLap.Visible = false;
            }
            if (panelsubmenuBaoCao.Visible == true)
            {
                panelsubmenuBaoCao.Visible = false;
            }
            if (panelsubmenuGiaiTri.Visible == true)
            {
                panelsubmenuGiaiTri.Visible = false;
            }
        }
        private void Showsubmenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hidesubmenu();
                SubMenu.Visible = true;

            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            Showsubmenu(panelsubmenuHoatDong);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            Showsubmenu(panelsubmenuBaoCao);
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            Showsubmenu(panelsubmenuThietLap);
        }

        private void btnHeThong_Click_1(object sender, EventArgs e)
        {
            Showsubmenu(panelsubmenuHeThong);
        }
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            
            if (panelChinh.Controls.Contains(ChildForm))
            {
                panelChinh.Controls.Remove(ChildForm);
            }
            
            panelChinh.Controls.Add(ChildForm);
            panelChinh.Tag = ChildForm;
            
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatBan());
        }

        private void panelChinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("btnHoaDon_Click được gọi");
            //if (CheckLoginRequired())
            //{
            //    Console.WriteLine("Đã pass CheckLoginRequired, đang mở FormHoaDon");
            //    try 
            //    {
            //        if (activeForm != null)
            //        {
            //            activeForm.Close();
            //            activeForm = null;
            //        }
                    
            //        FormHoaDon formHoaDon = new FormHoaDon();
            //        OpenChildForm(formHoaDon);
            //        Console.WriteLine("FormHoaDon đã được mở thành công");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Lỗi khi mở FormHoaDon: {ex.Message}");
            //        Console.WriteLine($"Stack trace: {ex.StackTrace}");
            //        MessageBox.Show($"Lỗi khi mở form Hóa Đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Không pass được CheckLoginRequired");
            //}
        }

        private void btnNhapXuatKho_Click(object sender, EventArgs e)
        {
            //if (CheckLoginRequired())
            //{
            //    OpenChildForm(new frmNhapXuatKho());
            //}
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            //if (CheckAccess(true))
            //{
            //    OpenChildForm(new frmThongKe());
            //}
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            //if (CheckAccess(true))
            //{
            //    OpenChildForm(new frmDoanhThu());
            //}
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            //if (CheckAccess(true))
            //{
            //    OpenChildForm(new frmMonAn());
            //}
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            //if (CheckLoginRequired())
            //{
                OpenDatHang();
            //}
        }

        private void OpenDatHang()
        {
            var form = new frmDatHang();
            OpenChildForm(form);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyBan());
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            
            
               OpenChildForm(new ThongTinKH());
            
        }

        private void btninforNhanVien_Click(object sender, EventArgs e)
        {
            
                OpenChildForm(new ThongtinNhanVien());
            
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            //if (GlobalState.IsLoggedIn)
            //{
            //    DialogResult result = MessageBox.Show("Hiện đã đăng nhập, bạn có muốn đăng xuất không?", 
            //        "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            //    if (result == DialogResult.Yes)
            //    {
            //        GlobalState.Logout();
            //        UpdateLoginStatus();
                    
            //        if (activeForm != null)
            //        {
            //            activeForm.Close();
            //            activeForm = null;
            //        }
                    
            //        frmDangNhap dn = new frmDangNhap();
            //        if (dn.ShowDialog() == DialogResult.OK)
            //        {
            //            UpdateLoginStatus();
            //        }
            //    }
            //}
            //else
            //{
            //    frmDangNhap dn = new frmDangNhap();
            //    if (dn.ShowDialog() == DialogResult.OK)
            //    {
            //        UpdateLoginStatus();
            //    }
            //}
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            //if (GlobalState.IsLoggedIn)
            //{
            //    DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        GlobalState.Logout();
            //        UpdateLoginStatus();
            //        if (activeForm != null)
            //        {
            //            activeForm.Close();
            //            activeForm = null;
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Bạn chưa đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnGiaiTri_Click(object sender, EventArgs e)
        {
            Showsubmenu(panelsubmenuGiaiTri);
        }

        private void btnSudoku_Click(object sender, EventArgs e)
        {
            //frmSudoku sudokuForm = new frmSudoku();
            //sudokuForm.Show(); 
            //hidesubmenu();
        }
    }
}
