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
            if (string.IsNullOrWhiteSpace(obj.MaNV) ||
                string.IsNullOrWhiteSpace(obj.HoTen) ||
                string.IsNullOrWhiteSpace(obj.MatKhau))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(NhanVienDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maNV) => dao.Xoa(maNV);

        public NhanVienDTO DangNhap(string username, string password)
        {
            
            return dao.DangNhap(username, password);
        }
    }
}
