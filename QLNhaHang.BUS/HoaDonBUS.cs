using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class HoaDonBUS
    {
       private HoaDonDAO dao = new HoaDonDAO();

        public List<HoaDonDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(HoaDonDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaHoaDon) || string.IsNullOrWhiteSpace(obj.MaDatBan) || string.IsNullOrWhiteSpace(obj.MaNV))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(HoaDonDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maHoaDon) => dao.Xoa(maHoaDon);
    }
}
