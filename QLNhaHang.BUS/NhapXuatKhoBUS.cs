using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;
namespace QLNhaHang.BUS
{
    public class NhapXuatKhoBUS
    {
        private NhapXuatKhoDAO dao = new NhapXuatKhoDAO();

        public List<NhapXuatKhoDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(NhapXuatKhoDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaNXK) || string.IsNullOrWhiteSpace(obj.MaMH) || string.IsNullOrWhiteSpace(obj.LoaiGiaoDich))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(NhapXuatKhoDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maNXK) => dao.Xoa(maNXK);
    }
}
