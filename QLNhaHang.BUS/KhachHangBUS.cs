using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO dao = new KhachHangDAO();

        public List<KhachHangDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        public bool Them(KhachHangDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaKH) || string.IsNullOrWhiteSpace(obj.TenKH))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(KhachHangDTO obj)
        {
            return dao.CapNhat(obj);
        }

        public bool Xoa(string maKH)
        {
            return dao.Xoa(maKH);
        }
    }
}
