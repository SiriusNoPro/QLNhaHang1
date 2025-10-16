using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
    public class MatHangDAO
    {
        public List<MatHangDTO> LayTatCa()
        {
            var list = new List<MatHangDTO>();
            string query = "SELECT * FROM MatHang";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new MatHangDTO
                        {
                            MaMH = r["MaMH"].ToString(),
                            TenMH = r["TenMH"].ToString(),
                            TrangThai = r["TrangThai"].ToString(),
                            MoTa = r["MoTa"].ToString(),
                            ThoiGianCheBien = r["ThoiGianCheBien"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["ThoiGianCheBien"]),
                            HinhAnh = r["HinhAnh"] == DBNull.Value ? null : r["HinhAnh"].ToString(),
                            MaLoaiMH = r["MaLoaiMH"].ToString(),
                            Gia = Convert.ToDecimal(r["Gia"])
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(MatHangDTO obj)
        {
            string query = "INSERT INTO MatHang(MaMH, TenMH, TrangThai, MoTa, ThoiGianCheBien, HinhAnh, MaLoaiMH, Gia) " +
                           "VALUES(@a,@b,@c,@d,@e,@f,@g,@h)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaMH);
                cmd.Parameters.AddWithValue("@b", obj.TenMH);
                cmd.Parameters.AddWithValue("@c", (object)obj.TrangThai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d", obj.MoTa);
                cmd.Parameters.AddWithValue("@e", (object)obj.ThoiGianCheBien ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.HinhAnh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", obj.MaLoaiMH);
                cmd.Parameters.AddWithValue("@h", obj.Gia);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(MatHangDTO obj)
        {
            string query = "UPDATE MatHang SET TenMH=@b, TrangThai=@c, MoTa=@d, ThoiGianCheBien=@e, HinhAnh=@f, MaLoaiMH=@g, Gia=@h WHERE MaMH=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaMH);
                cmd.Parameters.AddWithValue("@b", obj.TenMH);
                cmd.Parameters.AddWithValue("@c", (object)obj.TrangThai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d", obj.MoTa);
                cmd.Parameters.AddWithValue("@e", (object)obj.ThoiGianCheBien ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.HinhAnh ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", obj.MaLoaiMH);
                cmd.Parameters.AddWithValue("@h", obj.Gia);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maMH)
        {
            string query = "DELETE FROM MatHang WHERE MaMH=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maMH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
