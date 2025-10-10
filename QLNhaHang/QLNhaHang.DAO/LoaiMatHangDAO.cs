using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
    public class LoaiMatHangDAO
    {
        public List<LoaiMatHangDTO> LayTatCa()
        {
            var list = new List<LoaiMatHangDTO>();
            string query = "SELECT MaLoaiMH, TenLoaiMH FROM LoaiMatHang";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new LoaiMatHangDTO
                        {
                            MaLoaiMH = r["MaLoaiMH"].ToString(),
                            TenLoaiMH = r["TenLoaiMH"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(LoaiMatHangDTO obj)
        {
            string query = "INSERT INTO LoaiMatHang(MaLoaiMH, TenLoaiMH) VALUES(@a,@b)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaLoaiMH);
                cmd.Parameters.AddWithValue("@b", obj.TenLoaiMH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(LoaiMatHangDTO obj)
        {
            string query = "UPDATE LoaiMatHang SET TenLoaiMH=@b WHERE MaLoaiMH=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaLoaiMH);
                cmd.Parameters.AddWithValue("@b", obj.TenLoaiMH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maLoaiMH)
        {
            string query = "DELETE FROM LoaiMatHang WHERE MaLoaiMH=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maLoaiMH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
