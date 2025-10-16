using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;

namespace QLNhaHang.DAO
{
    public class NhanVienDAO
    {
        public List<NhanVienDTO> LayTatCa()
        {
            var list = new List<NhanVienDTO>();
            string query = "SELECT * FROM NhanVien";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new NhanVienDTO
                        {
                            MaNV = r["MaNV"].ToString(),
                            HoTen = r["HoTen"].ToString(),
                            NgaySinh = r["NgaySinh"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgaySinh"]),
                            GioiTinh = r["GioiTinh"] == DBNull.Value ? null : r["GioiTinh"].ToString(),
                            ChucVu = r["ChucVu"] == DBNull.Value ? null : r["ChucVu"].ToString(),
                            SoDienThoai = r["SoDienThoai"] == DBNull.Value ? null : r["SoDienThoai"].ToString(),
                            Email = r["Email"] == DBNull.Value ? null : r["Email"].ToString(),
                            DiaChi = r["DiaChi"] == DBNull.Value ? null : r["DiaChi"].ToString(),
                            HinhAnh = r["HinhAnh"] == DBNull.Value ? null : r["HinhAnh"].ToString(),
                            TaiKhoan = r["TaiKhoan"] == DBNull.Value ? null : r["TaiKhoan"].ToString(),
                            MatKhau = r["MatKhau"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(NhanVienDTO obj)
        {
            string query = @"INSERT INTO NhanVien
                            (MaNV, HoTen, NgaySinh, GioiTinh, ChucVu, SoDienThoai, Email, DiaChi, HinhAnh, TaiKhoan, MatKhau)
                            VALUES(@a,@b,@ns,@c,@d,@e,@f,@g,@h,@i,@j)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaNV);
                cmd.Parameters.AddWithValue("@b", obj.HoTen);
                cmd.Parameters.AddWithValue("@ns", (object)obj.NgaySinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@c", (object)obj.GioiTinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d", (object)obj.ChucVu ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", (object)obj.SoDienThoai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", (object)obj.DiaChi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@h", (object)obj.HinhAnh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@i", (object)obj.TaiKhoan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@j", obj.MatKhau);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(NhanVienDTO obj)
        {
            string query = @"UPDATE NhanVien 
                             SET HoTen=@b, NgaySinh=@ns, GioiTinh=@c, ChucVu=@d, 
                                 SoDienThoai=@e, Email=@f, DiaChi=@g, HinhAnh=@h, 
                                 TaiKhoan=@i, MatKhau=@j 
                             WHERE MaNV=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaNV);
                cmd.Parameters.AddWithValue("@b", obj.HoTen);
                cmd.Parameters.AddWithValue("@ns", (object)obj.NgaySinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@c", (object)obj.GioiTinh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d", (object)obj.ChucVu ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", (object)obj.SoDienThoai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", (object)obj.DiaChi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@h", (object)obj.HinhAnh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@i", (object)obj.TaiKhoan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@j", obj.MatKhau);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maNV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public NhanVienDTO DangNhap(string taiKhoan, string matKhau)
        {
            string query = "SELECT * FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tk", taiKhoan);
                cmd.Parameters.AddWithValue("@mk", matKhau);
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        return new NhanVienDTO
                        {
                            MaNV = r["MaNV"].ToString(),
                            HoTen = r["HoTen"].ToString(),
                            NgaySinh = r["NgaySinh"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["NgaySinh"]),
                            ChucVu = r["ChucVu"] == DBNull.Value ? null : r["ChucVu"].ToString(),
                            TaiKhoan = r["TaiKhoan"].ToString(),
                            MatKhau = r["MatKhau"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}
