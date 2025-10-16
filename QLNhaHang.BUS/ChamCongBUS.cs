using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class ChamCongBUS
    {
        private ChamCongDAO dao = new ChamCongDAO();

        public List<ChamCongDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(ChamCongDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaChamCong) || string.IsNullOrWhiteSpace(obj.MaNV) || string.IsNullOrWhiteSpace(obj.MaCa))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(ChamCongDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maChamCong) => dao.Xoa(maChamCong);
    }
}
