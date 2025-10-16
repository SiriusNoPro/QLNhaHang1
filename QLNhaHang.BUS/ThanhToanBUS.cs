using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class ThanhToanBUS
    {
        private ThanhToanDAO dao = new ThanhToanDAO();

        public List<ThanhToanDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(ThanhToanDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaThanhToan) || string.IsNullOrWhiteSpace(obj.MaHoaDon))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(ThanhToanDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maThanhToan) => dao.Xoa(maThanhToan);
    }
}
