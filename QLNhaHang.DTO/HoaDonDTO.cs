using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public string MaDatBan { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal? TienBan { get; set; }
        public decimal? TienDichVu { get; set; }
        public decimal? PhuPhi { get; set; }
        public decimal TongTien { get; set; }
        public string MaNV { get; set; }
        public string MaDoanhThu { get; set; }
    }
}
