using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using QLNhaHang.DAO;
namespace QLNhaHang.BUS
{
    public class MatHangBUS
    {
        private MatHangDAO dao = new MatHangDAO();

        public List<MatHangDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(MatHangDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaMH) || string.IsNullOrWhiteSpace(obj.TenMH) || string.IsNullOrWhiteSpace(obj.MaLoaiMH))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(MatHangDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maMH) => dao.Xoa(maMH);
    }
}
