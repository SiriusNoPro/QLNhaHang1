using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class BanNhaHangDAO
    {
        public List<BanNhaHangDTO> LayTatCa()
        {
            var list = new List<BanNhaHangDTO>();
            string query = "SELECT MaBan, TenBan, MaLoaiBan, TrangThai, SoLuongKhach, MaNV FROM BanNhaHang";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new BanNhaHangDTO
                        {
                            MaBan = r["MaBan"].ToString(),
                            TenBan = r["TenBan"].ToString(),
                            MaLoaiBan = r["MaLoaiBan"].ToString(),
                            TrangThai = r["TrangThai"] == DBNull.Value ? null : r["TrangThai"].ToString(),
                            SoLuongKhach = r["SoLuongKhach"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["SoLuongKhach"]),
                            MaNV = r["MaNV"] == DBNull.Value ? null : r["MaNV"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(BanNhaHangDTO obj)
        {
            string query = "INSERT INTO BanNhaHang(MaBan, TenBan, MaLoaiBan, TrangThai, SoLuongKhach, MaNV) " +
                           "VALUES(@a,@b,@c,@d,@e,@f)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaBan);
                cmd.Parameters.AddWithValue("@b", obj.TenBan);
                cmd.Parameters.AddWithValue("@c", obj.MaLoaiBan);
                cmd.Parameters.AddWithValue("@d", (object)obj.TrangThai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", (object)obj.SoLuongKhach ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.MaNV ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(BanNhaHangDTO obj)
        {
            string query = "UPDATE BanNhaHang SET TenBan=@b, MaLoaiBan=@c, TrangThai=@d, SoLuongKhach=@e, MaNV=@f WHERE MaBan=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaBan);
                cmd.Parameters.AddWithValue("@b", obj.TenBan);
                cmd.Parameters.AddWithValue("@c", obj.MaLoaiBan);
                cmd.Parameters.AddWithValue("@d", (object)obj.TrangThai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", (object)obj.SoLuongKhach ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.MaNV ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maBan)
        {
            string query = "DELETE FROM BanNhaHang WHERE MaBan=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maBan);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
