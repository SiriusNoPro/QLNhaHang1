using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class DatBanDTO
    {
        public string MaDatBan { get; set; }
        public string MaKH { get; set; }
        public string MaBan { get; set; }
        public string MaNV { get; set; }
        public DateTime ThoiGianDat { get; set; }
        public int? SoLuongKhach { get; set; }
        public string YeuCau { get; set; }
        public string TrangThai { get; set; }
    }
}
