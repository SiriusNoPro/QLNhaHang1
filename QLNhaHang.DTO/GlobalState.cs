using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhaHang.DTO
{
    public class GlobalState
    {
        public static QLNhaHang.DTO.NhanVienDTO CurrentUser { get; set; }
        public static bool IsLoggedIn { get; set; }
    }
}
