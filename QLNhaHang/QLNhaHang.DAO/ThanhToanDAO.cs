using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class ThanhToanDAO
    {
        public List<ThanhToanDTO> LayTatCa()
        {
            var list = new List<ThanhToanDTO>();
            string query = "SELECT * FROM ThanhToan";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new ThanhToanDTO
                        {
                            MaThanhToan = r["MaThanhToan"].ToString(),
                            MaHoaDon = r["MaHoaDon"].ToString(),
                            LoaiThanhToan = r["LoaiThanhToan"].ToString(),
                            SoTien = Convert.ToDecimal(r["SoTien"]),
                            TienKhachDua = r["TienKhachDua"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(r["TienKhachDua"]),
                            TienThua = r["TienThua"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(r["TienThua"]),
                            ThoiGian = Convert.ToDateTime(r["ThoiGian"]),
                            GhiChu = r["GhiChu"] == DBNull.Value ? null : r["GhiChu"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(ThanhToanDTO obj)
        {
            string query = "INSERT INTO ThanhToan(MaThanhToan, MaHoaDon, LoaiThanhToan, SoTien, TienKhachDua, TienThua, ThoiGian, GhiChu) " +
                           "VALUES(@a,@b,@c,@d,@e,@f,@g,@h)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaThanhToan);
                cmd.Parameters.AddWithValue("@b", obj.MaHoaDon);
                cmd.Parameters.AddWithValue("@c", obj.LoaiThanhToan);
                cmd.Parameters.AddWithValue("@d", obj.SoTien);
                cmd.Parameters.AddWithValue("@e", (object)obj.TienKhachDua ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.TienThua ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", obj.ThoiGian);
                cmd.Parameters.AddWithValue("@h", (object)obj.GhiChu ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(ThanhToanDTO obj)
        {
            string query = "UPDATE ThanhToan SET MaHoaDon=@b, LoaiThanhToan=@c, SoTien=@d, TienKhachDua=@e, TienThua=@f, ThoiGian=@g, GhiChu=@h WHERE MaThanhToan=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaThanhToan);
                cmd.Parameters.AddWithValue("@b", obj.MaHoaDon);
                cmd.Parameters.AddWithValue("@c", obj.LoaiThanhToan);
                cmd.Parameters.AddWithValue("@d", obj.SoTien);
                cmd.Parameters.AddWithValue("@e", (object)obj.TienKhachDua ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.TienThua ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", obj.ThoiGian);
                cmd.Parameters.AddWithValue("@h", (object)obj.GhiChu ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maThanhToan)
        {
            string query = "DELETE FROM ThanhToan WHERE MaThanhToan=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maThanhToan);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
