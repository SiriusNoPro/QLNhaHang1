using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class DoanhThuDAO
    {
        public List<DoanhThuDTO> LayTatCa()
        {
            var list = new List<DoanhThuDTO>();
            string query = "SELECT MaDoanhThu, Ngay, TongDoanhThu FROM DoanhThu";

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new DoanhThuDTO
                        {
                            MaDoanhThu = r["MaDoanhThu"].ToString(),
                            Ngay = Convert.ToDateTime(r["Ngay"]),
                            TongDoanhThu = Convert.ToDecimal(r["TongDoanhThu"])
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(DoanhThuDTO obj)
        {
            string query = "INSERT INTO DoanhThu(MaDoanhThu, Ngay, TongDoanhThu) VALUES(@a,@b,@c)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaDoanhThu);
                cmd.Parameters.AddWithValue("@b", obj.Ngay);
                cmd.Parameters.AddWithValue("@c", obj.TongDoanhThu);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(DoanhThuDTO obj)
        {
            string query = "UPDATE DoanhThu SET Ngay=@b, TongDoanhThu=@c WHERE MaDoanhThu=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaDoanhThu);
                cmd.Parameters.AddWithValue("@b", obj.Ngay);
                cmd.Parameters.AddWithValue("@c", obj.TongDoanhThu);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maDoanhThu)
        {
            string query = "DELETE FROM DoanhThu WHERE MaDoanhThu=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maDoanhThu);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
