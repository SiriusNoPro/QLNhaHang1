using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class LoaiBan
    {

        private LoaiBanDAO dao = new LoaiBanDAO();

        public List<LoaiBanDTO> LayTatCa()
        {
            return dao.LayTatCa();
        }

        public bool Them(LoaiBanDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaLoaiBan) || string.IsNullOrWhiteSpace(obj.TenLoaiBan))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(LoaiBanDTO obj)
        {
            return dao.CapNhat(obj);
        }

        public bool Xoa(string maLoaiBan)
        {
            return dao.Xoa(maLoaiBan);
        }
    }
}
