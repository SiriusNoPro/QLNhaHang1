using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;

namespace QLNhaHang.BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
        }

        private NhanVienDAO dao = new NhanVienDAO();

        private NhanVienBUS() { }

        public List<NhanVienDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(NhanVienDTO obj)
        {
            // Kiểm tra dữ liệu bắt buộc
            if (string.IsNullOrWhiteSpace(obj.MaNV) ||
                string.IsNullOrWhiteSpace(obj.HoTen) ||
                string.IsNullOrWhiteSpace(obj.MatKhau))
                return false;

            // Kiểm tra ngày sinh (nếu có)
            if (obj.NgaySinh != null && obj.NgaySinh > DateTime.Now)
                return false; // Không được lớn hơn ngày hiện tại

            return dao.Them(obj);
        }

        public bool CapNhat(NhanVienDTO obj)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(obj.MaNV))
                return false;

            if (obj.NgaySinh != null && obj.NgaySinh > DateTime.Now)
                return false;

            return dao.CapNhat(obj);
        }

        public bool Xoa(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV))
                return false;
            return dao.Xoa(maNV);
        }

        public NhanVienDTO DangNhap(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            return dao.DangNhap(username, password);
        }
    }
}
