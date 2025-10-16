using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;

namespace QLNhaHang.BUS
{
    public class ThanhVienBUS
    {
        private ThanhVienDAO dao = new ThanhVienDAO();

        public List<ThanhVienDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        public bool Them(ThanhVienDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaTheThanhVien) || string.IsNullOrWhiteSpace(obj.MaKH))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(ThanhVienDTO obj)
        {
            return dao.CapNhat(obj);
        }

        public bool Xoa(string maThe)
        {
            return dao.Xoa(maThe);
        }
    }
}
