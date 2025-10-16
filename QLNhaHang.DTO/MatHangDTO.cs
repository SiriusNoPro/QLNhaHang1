using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class MatHangDTO
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string TrangThai { get; set; }
        public string MoTa { get; set; }
        public int? ThoiGianCheBien { get; set; }
        public string HinhAnh { get; set; }
        public string MaLoaiMH { get; set; }
        public decimal Gia { get; set; }
    }
}
