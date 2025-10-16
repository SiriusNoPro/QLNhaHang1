using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class DichVuBanAnBUS
    {
        private DichVuBanAnDAO dao = new DichVuBanAnDAO();

        public List<DichVuBanAnDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(DichVuBanAnDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaDV) || string.IsNullOrWhiteSpace(obj.MaDatBan) || string.IsNullOrWhiteSpace(obj.MaMH))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(DichVuBanAnDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maDV) => dao.Xoa(maDV);

    }
}
