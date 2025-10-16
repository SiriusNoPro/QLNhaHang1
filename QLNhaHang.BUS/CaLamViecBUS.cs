using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class CaLamViecBUS
    {
        private CaLamViecDAO dao = new CaLamViecDAO();

        public List<CaLamViecDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(CaLamViecDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaCa) || string.IsNullOrWhiteSpace(obj.TenCa))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(CaLamViecDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maCa) => dao.Xoa(maCa);
    }
}
