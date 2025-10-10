using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class DoanhThuBUS
    {
        private DoanhThuDAO dao = new DoanhThuDAO();

        public List<DoanhThuDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(DoanhThuDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaDoanhThu))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(DoanhThuDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maDoanhThu) => dao.Xoa(maDoanhThu);
    }
}
