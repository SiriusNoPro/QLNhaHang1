using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class ThongBaoDTO
    {
        public string MaThongBao { get; set; }
        public string LoaiThongBao { get; set; }
        public string NoiDung { get; set; }
        public string MaNVTo { get; set; }
        public bool DaDoc { get; set; }
        public DateTime ThoiGian { get; set; }
        public string MaGoiMon { get; set; }
    }
}
