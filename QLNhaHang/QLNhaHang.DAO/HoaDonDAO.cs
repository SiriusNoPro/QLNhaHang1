using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class HoaDonDAO
    {
        public List<HoaDonDTO> LayTatCa()
        {
            var list = new List<HoaDonDTO>();
            string query = "SELECT * FROM HoaDon";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new HoaDonDTO
                        {
                            MaHoaDon = r["MaHoaDon"].ToString(),
                            MaDatBan = r["MaDatBan"].ToString(),
                            NgayLap = Convert.ToDateTime(r["NgayLap"]),
                            TienBan = r["TienBan"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["TienBan"]),
                            TienDichVu = r["TienDichVu"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["TienDichVu"]),
                            PhuPhi = r["PhuPhi"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["PhuPhi"]),
                            TongTien = Convert.ToDecimal(r["TongTien"]),
                            MaNV = r["MaNV"].ToString(),
                            MaDoanhThu = r["MaDoanhThu"] == DBNull.Value ? null : r["MaDoanhThu"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(HoaDonDTO obj)
        {
            string query = "INSERT INTO HoaDon(MaHoaDon, MaDatBan, NgayLap, TienBan, TienDichVu, PhuPhi, TongTien, MaNV, MaDoanhThu) " +
                           "VALUES(@a,@b,@c,@d,@e,@f,@g,@h,@i)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaHoaDon);
                cmd.Parameters.AddWithValue("@b", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@c", obj.NgayLap);
                cmd.Parameters.AddWithValue("@d", (object)obj.TienBan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", (object)obj.TienDichVu ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.PhuPhi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", obj.TongTien);
                cmd.Parameters.AddWithValue("@h", obj.MaNV);
                cmd.Parameters.AddWithValue("@i", (object)obj.MaDoanhThu ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(HoaDonDTO obj)
        {
            string query = "UPDATE HoaDon SET MaDatBan=@b, NgayLap=@c, TienBan=@d, TienDichVu=@e, PhuPhi=@f, TongTien=@g, MaNV=@h, MaDoanhThu=@i WHERE MaHoaDon=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaHoaDon);
                cmd.Parameters.AddWithValue("@b", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@c", obj.NgayLap);
                cmd.Parameters.AddWithValue("@d", (object)obj.TienBan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", (object)obj.TienDichVu ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.PhuPhi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", obj.TongTien);
                cmd.Parameters.AddWithValue("@h", obj.MaNV);
                cmd.Parameters.AddWithValue("@i", (object)obj.MaDoanhThu ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maHoaDon)
        {
            string query = "DELETE FROM HoaDon WHERE MaHoaDon=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maHoaDon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
