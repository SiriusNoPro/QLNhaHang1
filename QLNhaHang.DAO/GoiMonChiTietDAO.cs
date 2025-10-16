using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
    public class GoiMonChiTietDAO
    {
        public List<GoiMonChiTietDTO> LayTatCa()
        {
            var list = new List<GoiMonChiTietDTO>();
            string query = "SELECT * FROM GoiMonChiTiet";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new GoiMonChiTietDTO
                        {
                            MaGoiMonCT = r["MaGoiMonCT"].ToString(),
                            MaGoiMon = r["MaGoiMon"].ToString(),
                            MaMH = r["MaMH"].ToString(),
                            SoLuong = Convert.ToInt32(r["SoLuong"]),
                            GiaTaiThoiDiem = Convert.ToDateTime(r["GiaTaiThoiDiem"]),
                            TrangThai = r["TrangThai"].ToString(),
                            MaNVBep = r["MaNVBep"] == DBNull.Value ? null : r["MaNVBep"].ToString(),
                            ThoiGianTrangThai = r["ThoiGianTrangThai"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(r["ThoiGianTrangThai"]),
                            GhiChu = r["GhiChu"] == DBNull.Value ? null : r["GhiChu"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(GoiMonChiTietDTO obj)
        {
            string query = "INSERT INTO GoiMonChiTiet(MaGoiMonCT, MaGoiMon, MaMH, SoLuong, GiaTaiThoiDiem, TrangThai, MaNVBep, ThoiGianTrangThai, GhiChu) " +
                           "VALUES(@a,@b,@c,@d,@e,@f,@g,@h,@i)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaGoiMonCT);
                cmd.Parameters.AddWithValue("@b", obj.MaGoiMon);
                cmd.Parameters.AddWithValue("@c", obj.MaMH);
                cmd.Parameters.AddWithValue("@d", obj.SoLuong);
                cmd.Parameters.AddWithValue("@e", obj.GiaTaiThoiDiem);
                cmd.Parameters.AddWithValue("@f", obj.TrangThai);
                cmd.Parameters.AddWithValue("@g", (object)obj.MaNVBep ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@h", (object)obj.ThoiGianTrangThai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@i", (object)obj.GhiChu ?? DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(GoiMonChiTietDTO obj)
        {
            string query = "UPDATE GoiMonChiTiet SET MaGoiMon=@b, MaMH=@c, SoLuong=@d, GiaTaiThoiDiem=@e, TrangThai=@f, MaNVBep=@g, ThoiGianTrangThai=@h, GhiChu=@i WHERE MaGoiMonCT=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaGoiMonCT);
                cmd.Parameters.AddWithValue("@b", obj.MaGoiMon);
                cmd.Parameters.AddWithValue("@c", obj.MaMH);
                cmd.Parameters.AddWithValue("@d", obj.SoLuong);
                cmd.Parameters.AddWithValue("@e", obj.GiaTaiThoiDiem);
                cmd.Parameters.AddWithValue("@f", obj.TrangThai);
                cmd.Parameters.AddWithValue("@g", (object)obj.MaNVBep ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@h", (object)obj.ThoiGianTrangThai ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@i", (object)obj.GhiChu ?? DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maGoiMonCT)
        {
            string query = "DELETE FROM GoiMonChiTiet WHERE MaGoiMonCT=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maGoiMonCT);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
