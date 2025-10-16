using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class ThongBaoBUS
    {
        private ThongBaoDAO dao = new ThongBaoDAO();

        public List<ThongBaoDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(ThongBaoDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaThongBao) || string.IsNullOrWhiteSpace(obj.LoaiThongBao))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(ThongBaoDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maThongBao) => dao.Xoa(maThongBao);
    }
}
