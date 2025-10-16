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
            string query = "SELECT MaDatBan, MaKH, MaBan, ThoiGianDat, SoLuongKhach, YeuCau, TrangThai FROM DatBan";

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
                            // MaNV not present in schema
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
            string query = "INSERT INTO DatBan(MaDatBan, MaKH, MaBan, ThoiGianDat, SoLuongKhach, YeuCau, TrangThai) " +
                           "VALUES(@a,@b,@c,@d,@e,@f,@g)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@b", obj.MaKH);
                cmd.Parameters.AddWithValue("@c", obj.MaBan);
                cmd.Parameters.AddWithValue("@d", obj.ThoiGianDat);
                cmd.Parameters.AddWithValue("@e", (object)obj.SoLuongKhach ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.YeuCau ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", (object)obj.TrangThai ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(DatBanDTO obj)
        {
            string query = "UPDATE DatBan SET MaKH=@b, MaBan=@c, ThoiGianDat=@d, SoLuongKhach=@e, YeuCau=@f, TrangThai=@g WHERE MaDatBan=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@b", obj.MaKH);
                cmd.Parameters.AddWithValue("@c", obj.MaBan);
                cmd.Parameters.AddWithValue("@d", obj.ThoiGianDat);
                cmd.Parameters.AddWithValue("@e", (object)obj.SoLuongKhach ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@f", (object)obj.YeuCau ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@g", (object)obj.TrangThai ?? DBNull.Value);
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

        public bool KiemTraBanRanh(string maBan, DateTime thoiGianBatDau, TimeSpan thoiLuong)
        {
            // xem có đặt bàn trùng khoảng thời gian không (Đặt trước hoặc Đang sử dụng)
            string query = @"SELECT COUNT(1) FROM DatBan 
                              WHERE MaBan=@maBan AND TrangThai IN ('DaDatTruoc','DangSuDung')
                                AND ABS(DATEDIFF(MINUTE, ThoiGianDat, @tgbd)) < @phut OR ABS(DATEDIFF(MINUTE, @tgbd, ThoiGianDat)) < @phut";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@maBan", maBan);
                cmd.Parameters.AddWithValue("@tgbd", thoiGianBatDau);
                cmd.Parameters.AddWithValue("@phut", (int)thoiLuong.TotalMinutes);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
        }
    }
}
