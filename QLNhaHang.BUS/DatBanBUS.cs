using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DAO;
using QLNhaHang.DTO;

namespace QLNhaHang.BUS
{
    public class DatBanBUS
    {
        private DatBanDAO dao = new DatBanDAO();
        private BanNhaHangDAO banDao = new BanNhaHangDAO();

        public List<DatBanDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(DatBanDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaDatBan) || string.IsNullOrWhiteSpace(obj.MaKH) || string.IsNullOrWhiteSpace(obj.MaBan))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(DatBanDTO obj) => dao.CapNhat(obj);

        public bool Xoa(string maDatBan) => dao.Xoa(maDatBan);

        public bool KiemTraBanRanh(string maBan, DateTime thoiGian, TimeSpan thoiLuong)
        {
            if (string.IsNullOrWhiteSpace(maBan)) return false;
            return dao.KiemTraBanRanh(maBan, thoiGian, thoiLuong);
        }

        public bool DatBanVaCapNhatTrangThai(DatBanDTO obj)
        {
            if (!Them(obj)) return false;
            return new BanNhaHangDAO().CapNhatTrangThai(obj.MaBan, "DaDatTruoc");
        }

        public bool ChuyenSangDangSuDung(string maBan)
        {
            return new BanNhaHangDAO().CapNhatTrangThai(maBan, "DangSuDung");
        }

        public bool ChuyenVeTrong(string maBan)
        {
            return new BanNhaHangDAO().CapNhatTrangThai(maBan, "Trong");
        }
    }
}

