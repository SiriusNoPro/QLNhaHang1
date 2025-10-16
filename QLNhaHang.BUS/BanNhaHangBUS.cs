using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class BanNhaHangBUS
    {
        private BanNhaHangDAO dao = new BanNhaHangDAO();

        public List<BanNhaHangDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        public bool Them(BanNhaHangDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaBan) || string.IsNullOrWhiteSpace(obj.TenBan) || string.IsNullOrWhiteSpace(obj.MaLoaiBan))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(BanNhaHangDTO obj)
        {
            return dao.CapNhat(obj);
        }

        public bool Xoa(string maBan)
        {
            return dao.Xoa(maBan);
        }

        public bool CapNhatTrangThai(string maBan, string trangThai)
        {
            if (string.IsNullOrWhiteSpace(maBan)) return false;
            return dao.CapNhatTrangThai(maBan, trangThai);
        }
    }
}
