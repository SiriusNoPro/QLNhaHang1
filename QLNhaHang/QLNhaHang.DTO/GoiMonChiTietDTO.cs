using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class GoiMonChiTietDTO
    {
        public string MaGoiMonCT { get; set; }
        public string MaGoiMon { get; set; }
        public string MaMH { get; set; }
        public int SoLuong { get; set; }
        public DateTime GiaTaiThoiDiem { get; set; }
        public string TrangThai { get; set; }
        public string MaNVBep { get; set; }
        public DateTime? ThoiGianTrangThai { get; set; }
        public string GhiChu { get; set; }
    }
}
