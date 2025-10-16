using System;
using System.Collections.Generic;
using QLNhaHang.DAO;
using QLNhaHang.DTO;

namespace QLNhaHang.BUS
{
    public class LoaiBanBUS
    {
        private readonly LoaiBanDAO dao = new LoaiBanDAO();

        public List<LoaiBanDTO> LayTatCa() => dao.LayTatCa();

        public bool Them(LoaiBanDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaLoaiBan) || string.IsNullOrWhiteSpace(obj.TenLoaiBan))
                return false;
            return dao.Them(obj);
        }

        public bool CapNhat(LoaiBanDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.MaLoaiBan) || string.IsNullOrWhiteSpace(obj.TenLoaiBan))
                return false;
            return dao.CapNhat(obj);
        }

        public bool Xoa(string maLoaiBan)
        {
            if (string.IsNullOrWhiteSpace(maLoaiBan)) return false;
            return dao.Xoa(maLoaiBan);
        }
    }
}
