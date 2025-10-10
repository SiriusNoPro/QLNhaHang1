using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
    public class KhachHangDAO
    {
        public List<KhachHangDTO> LayTatCa()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            string query = "SELECT MaKH, TenKH, GioiTinh, SDT, Email, DiaChi, DiemTichLuy FROM KhachHang";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new KhachHangDTO
                        {
                            MaKH = r["MaKH"].ToString(),
                            TenKH = r["TenKH"].ToString(),
                            GioiTinh = r["GioiTinh"] == DBNull.Value ? null : r["GioiTinh"].ToString(),
                            SDT = r["SDT"] == DBNull.Value ? null : r["SDT"].ToString(),
                            Email = r["Email"] == DBNull.Value ? null : r["Email"].ToString(),
                            DiaChi = r["DiaChi"] == DBNull.Value ? null : r["DiaChi"].ToString(),
                            DiemTichLuy = r["DiemTichLuy"] == DBNull.Value ? 0 : Convert.ToInt32(r["DiemTichLuy"])
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(KhachHangDTO obj)
        {
            string query = "INSERT INTO KhachHang(MaKH, TenKH, GioiTinh, SDT, Email, DiaChi, DiemTichLuy) " +
                           "VALUES(@a,@b,@c,@d,@e,@f,@g)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaKH);
                cmd.Parameters.AddWithValue("@b", obj.TenKH);
                cmd.Parameters.AddWithValue("@c", (object)obj.GioiTinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d", (object)obj.SDT ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", (object)obj.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.DiaChi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", obj.DiemTichLuy);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(KhachHangDTO obj)
        {
            string query = "UPDATE KhachHang SET TenKH=@b, GioiTinh=@c, SDT=@d, Email=@e, DiaChi=@f, DiemTichLuy=@g WHERE MaKH=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaKH);
                cmd.Parameters.AddWithValue("@b", obj.TenKH);
                cmd.Parameters.AddWithValue("@c", (object)obj.GioiTinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d", (object)obj.SDT ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", (object)obj.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.DiaChi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", obj.DiemTichLuy);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maKH)
        {
            string query = "DELETE FROM KhachHang WHERE MaKH=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maKH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
