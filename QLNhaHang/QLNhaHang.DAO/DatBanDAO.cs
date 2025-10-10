using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class DatBanDAO
    {
        public List<DatBanDTO> LayTatCa()
        {
            var list = new List<DatBanDTO>();
            string query = "SELECT MaDatBan, MaKH, MaBan, MaNV, ThoiGianDat, SoLuongKhach, YeuCau, TrangThai FROM DatBan";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new DatBanDTO
                        {
                            MaDatBan = r["MaDatBan"].ToString(),
                            MaKH = r["MaKH"].ToString(),
                            MaBan = r["MaBan"].ToString(),
                            MaNV = r["MaNV"] == DBNull.Value ? null : r["MaNV"].ToString(),
                            ThoiGianDat = Convert.ToDateTime(r["ThoiGianDat"]),
                            SoLuongKhach = r["SoLuongKhach"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["SoLuongKhach"]),
                            YeuCau = r["YeuCau"] == DBNull.Value ? null : r["YeuCau"].ToString(),
                            TrangThai = r["TrangThai"] == DBNull.Value ? null : r["TrangThai"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(DatBanDTO obj)
        {
            string query = "INSERT INTO DatBan(MaDatBan, MaKH, MaBan, MaNV, ThoiGianDat, SoLuongKhach, YeuCau, TrangThai) " +
                           "VALUES(@a,@b,@c,@d,@e,@f,@g,@h)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@b", obj.MaKH);
                cmd.Parameters.AddWithValue("@c", obj.MaBan);
                cmd.Parameters.AddWithValue("@d", (object)obj.MaNV ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", obj.ThoiGianDat);
                cmd.Parameters.AddWithValue("@f", (object)obj.SoLuongKhach ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", (object)obj.YeuCau ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@h", (object)obj.TrangThai ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(DatBanDTO obj)
        {
            string query = "UPDATE DatBan SET MaKH=@b, MaBan=@c, MaNV=@d, ThoiGianDat=@e, SoLuongKhach=@f, YeuCau=@g, TrangThai=@h WHERE MaDatBan=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@b", obj.MaKH);
                cmd.Parameters.AddWithValue("@c", obj.MaBan);
                cmd.Parameters.AddWithValue("@d", (object)obj.MaNV ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", obj.ThoiGianDat);
                cmd.Parameters.AddWithValue("@f", (object)obj.SoLuongKhach ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", (object)obj.YeuCau ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@h", (object)obj.TrangThai ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maDatBan)
        {
            string query = "DELETE FROM DatBan WHERE MaDatBan=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maDatBan);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
