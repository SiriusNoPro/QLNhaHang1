using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class NhapXuatKhoDTO
    {
        public string MaNXK { get; set; }
        public string MaMH { get; set; }
        public string LoaiGiaoDich { get; set; } 
        public int SoLuong { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public string MaNV { get; set; }
    }
}
