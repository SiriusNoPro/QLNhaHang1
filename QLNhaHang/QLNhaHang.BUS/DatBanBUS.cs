using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;

namespace QLNhaHang.BUS
{
    public class DatBanBUS
    {
        private DatBanDAO dao = new DatBanDAO();

        public List<DatBanDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(DatBanDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaDatBan) || string.IsNullOrWhiteSpace(obj.MaKH) || string.IsNullOrWhiteSpace(obj.MaBan))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(DatBanDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maDatBan) => dao.Xoa(maDatBan);
    }
}

