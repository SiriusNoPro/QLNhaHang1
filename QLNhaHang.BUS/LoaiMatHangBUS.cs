using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class LoaiMatHangBUS
    {
        private LoaiMatHangDAO dao = new LoaiMatHangDAO();

        public List<LoaiMatHangDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(LoaiMatHangDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaLoaiMH) || string.IsNullOrWhiteSpace(obj.TenLoaiMH))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(LoaiMatHangDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maLoaiMH) => dao.Xoa(maLoaiMH);
    }
}

