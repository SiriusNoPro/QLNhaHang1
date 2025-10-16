using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class ChiTietHoaDonDAO
    {
        public List<ChiTietHoaDonDTO> LayTatCa()
        {
            var list = new List<ChiTietHoaDonDTO>();
            string query = "SELECT * FROM ChiTietHoaDon";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new ChiTietHoaDonDTO
                        {
                            MaCTHD = r["MaCTHD"].ToString(),
                            MaHoaDon = r["MaHoaDon"].ToString(),
                            MaMH = r["MaMH"].ToString(),
                            SoLuong = Convert.ToInt32(r["SoLuong"]),
                            GiaBan = Convert.ToDecimal(r["GiaBan"])
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(ChiTietHoaDonDTO obj)
        {
            string query = "INSERT INTO ChiTietHoaDon(MaCTHD, MaHoaDon, MaMH, SoLuong, GiaBan) VALUES(@a,@b,@c,@d,@e)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaCTHD);
                cmd.Parameters.AddWithValue("@b", obj.MaHoaDon);
                cmd.Parameters.AddWithValue("@c", obj.MaMH);
                cmd.Parameters.AddWithValue("@d", obj.SoLuong);
                cmd.Parameters.AddWithValue("@e", obj.GiaBan);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(ChiTietHoaDonDTO obj)
        {
            string query = "UPDATE ChiTietHoaDon SET MaHoaDon=@b, MaMH=@c, SoLuong=@d, GiaBan=@e WHERE MaCTHD=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaCTHD);
                cmd.Parameters.AddWithValue("@b", obj.MaHoaDon);
                cmd.Parameters.AddWithValue("@c", obj.MaMH);
                cmd.Parameters.AddWithValue("@d", obj.SoLuong);
                cmd.Parameters.AddWithValue("@e", obj.GiaBan);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maCTHD)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE MaCTHD=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maCTHD);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
