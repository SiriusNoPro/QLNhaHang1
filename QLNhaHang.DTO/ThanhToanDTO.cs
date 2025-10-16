using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class ThanhToanDTO
    {
        public string MaThanhToan { get; set; }
        public string MaHoaDon { get; set; }
        public string LoaiThanhToan { get; set; }
        public decimal SoTien { get; set; }
        public decimal? TienKhachDua { get; set; }
        public decimal? TienThua { get; set; }
        public DateTime ThoiGian { get; set; }
        public string GhiChu { get; set; }
    }
}
