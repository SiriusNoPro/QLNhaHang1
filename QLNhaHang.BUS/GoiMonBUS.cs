using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class GoiMonBUS
    {
        private GoiMonDAO dao = new GoiMonDAO();

        public List<GoiMonDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(GoiMonDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaGoiMon) || string.IsNullOrWhiteSpace(obj.MaDatBan))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(GoiMonDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maGoiMon) => dao.Xoa(maGoiMon);
    }
}
