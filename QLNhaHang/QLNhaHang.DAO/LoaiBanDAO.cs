using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
    public class LoaiBanDAO
    {
        public List<LoaiBanDTO> LayTatCa()
        {
            List<LoaiBanDTO> list = new List<LoaiBanDTO>();
            string query = "SELECT MaLoaiBan, TenLoaiBan, MoTa FROM LoaiBan";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LoaiBanDTO
                        {
                            MaLoaiBan = reader["MaLoaiBan"].ToString(),
                            TenLoaiBan = reader["TenLoaiBan"].ToString(),
                            MoTa = reader["MoTa"] == DBNull.Value ? null : reader["MoTa"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(LoaiBanDTO obj)
        {
            string query = "INSERT INTO LoaiBan(MaLoaiBan, TenLoaiBan, MoTa) VALUES(@a,@b,@c)";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaLoaiBan);
                cmd.Parameters.AddWithValue("@b", obj.TenLoaiBan);
                cmd.Parameters.AddWithValue("@c", (object)obj.MoTa ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(LoaiBanDTO obj)
        {
            string query = "UPDATE LoaiBan SET TenLoaiBan=@b, MoTa=@c WHERE MaLoaiBan=@a";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaLoaiBan);
                cmd.Parameters.AddWithValue("@b", obj.TenLoaiBan);
                cmd.Parameters.AddWithValue("@c", (object)obj.MoTa ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maLoaiBan)
        {
            string query = "DELETE FROM LoaiBan WHERE MaLoaiBan=@a";
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maLoaiBan);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

