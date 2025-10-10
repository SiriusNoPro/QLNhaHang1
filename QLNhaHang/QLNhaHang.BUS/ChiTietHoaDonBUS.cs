using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using QLNhaHang.DAO;

namespace QLNhaHang.BUS
{
    public class ChiTietHoaDonBUS
    {
        private ChiTietHoaDonDAO dao = new ChiTietHoaDonDAO();

        public List<ChiTietHoaDonDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(ChiTietHoaDonDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaCTHD) || string.IsNullOrWhiteSpace(obj.MaHoaDon) || string.IsNullOrWhiteSpace(obj.MaMH))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(ChiTietHoaDonDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maCTHD) => dao.Xoa(maCTHD);
    }
}
