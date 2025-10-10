using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class GoiMonChiTietBUS
    {
        private GoiMonChiTietDAO dao = new GoiMonChiTietDAO();

        public List<GoiMonChiTietDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(GoiMonChiTietDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaGoiMonCT) || string.IsNullOrWhiteSpace(obj.MaGoiMon) || string.IsNullOrWhiteSpace(obj.MaMH))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(GoiMonChiTietDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maGoiMonCT) => dao.Xoa(maGoiMonCT);
    }
}
