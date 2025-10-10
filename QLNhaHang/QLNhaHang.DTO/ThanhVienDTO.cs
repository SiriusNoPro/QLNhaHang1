using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class ThanhVienDTO
    {
        public string MaTheThanhVien { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime? NgayKichHoat { get; set; }
        public DateTime? HanSuDung { get; set; }
        public int DiemTichLuy { get; set; }
        public string TrangThai { get; set; }
    }
}
