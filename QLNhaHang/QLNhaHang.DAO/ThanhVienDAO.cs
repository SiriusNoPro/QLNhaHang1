using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
    public class ThanhVienDAO
    {
        public List<ThanhVienDTO> LayTatCa()
        {
            List<ThanhVienDTO> list = new List<ThanhVienDTO>();
            string query = "SELECT MaTheThanhVien, MaKH, NgayDangKy, NgayKichHoat, HanSuDung, DiemTichLuy, TrangThai FROM ThanhVien";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new ThanhVienDTO
                        {
                            MaTheThanhVien = r["MaTheThanhVien"].ToString(),
                            MaKH = r["MaKH"].ToString(),
                            NgayDangKy = Convert.ToDateTime(r["NgayDangKy"]),
                            NgayKichHoat = r["NgayKichHoat"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgayKichHoat"]),
                            HanSuDung = r["HanSuDung"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["HanSuDung"]),
                            DiemTichLuy = r["DiemTichLuy"] == DBNull.Value ? 0 : Convert.ToInt32(r["DiemTichLuy"]),
                            TrangThai = r["TrangThai"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(ThanhVienDTO obj)
        {
            string query = "INSERT INTO ThanhVien(MaTheThanhVien, MaKH, NgayDangKy, NgayKichHoat, DiemTichLuy, TrangThai) " +
                           "VALUES(@a,@b,@c,@d,@e,@f)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaTheThanhVien);
                cmd.Parameters.AddWithValue("@b", obj.MaKH);
                cmd.Parameters.AddWithValue("@c", obj.NgayDangKy);
                cmd.Parameters.AddWithValue("@d", (object)obj.NgayKichHoat ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", obj.DiemTichLuy);
                cmd.Parameters.AddWithValue("@f", obj.TrangThai);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(ThanhVienDTO obj)
        {
            string query = "UPDATE ThanhVien SET MaKH=@b, NgayDangKy=@c, NgayKichHoat=@d, DiemTichLuy=@e, TrangThai=@f WHERE MaTheThanhVien=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaTheThanhVien);
                cmd.Parameters.AddWithValue("@b", obj.MaKH);
                cmd.Parameters.AddWithValue("@c", obj.NgayDangKy);
                cmd.Parameters.AddWithValue("@d", (object)obj.NgayKichHoat ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", obj.DiemTichLuy);
                cmd.Parameters.AddWithValue("@f", obj.TrangThai);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maThe)
        {
            string query = "DELETE FROM ThanhVien WHERE MaTheThanhVien=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maThe);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
