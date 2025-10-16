using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class LichSuTichDiemDTO
    {
        public int MaLichSu { get; set; }
        public string MaKH { get; set; }
        public string MaHoaDon { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public int DiemThayDoi { get; set; }
        public string LoaiGiaoDich { get; set; }
        public string GhiChu { get; set; }
    }
}
