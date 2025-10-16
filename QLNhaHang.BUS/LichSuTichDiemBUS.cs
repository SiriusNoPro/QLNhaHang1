using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class LichSuTichDiemBUS
    {
        private LichSuTichDiemDAO dao = new LichSuTichDiemDAO();

        public List<LichSuTichDiemDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(LichSuTichDiemDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaKH) || string.IsNullOrWhiteSpace(obj.LoaiGiaoDich))
                return false;
            return dao.Them(obj);
        }

        public bool Xoa(int maLichSu) => dao.Xoa(maLichSu);
    }
}
