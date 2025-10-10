using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
    public class ChamCongDAO
    {
        public List<ChamCongDTO> LayTatCa()
        {
            var list = new List<ChamCongDTO>();
            string query = "SELECT * FROM ChamCong";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new ChamCongDTO
                        {
                            MaChamCong = r["MaChamCong"].ToString(),
                            MaNV = r["MaNV"].ToString(),
                            MaCa = r["MaCa"].ToString(),
                            Ngay = Convert.ToDateTime(r["Ngay"]),
                            TrangThai = r["TrangThai"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(ChamCongDTO obj)
        {
            string query = "INSERT INTO ChamCong(MaChamCong, MaNV, MaCa, Ngay, TrangThai) VALUES(@a,@b,@c,@d,@e)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaChamCong);
                cmd.Parameters.AddWithValue("@b", obj.MaNV);
                cmd.Parameters.AddWithValue("@c", obj.MaCa);
                cmd.Parameters.AddWithValue("@d", obj.Ngay);
                cmd.Parameters.AddWithValue("@e", obj.TrangThai);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(ChamCongDTO obj)
        {
            string query = "UPDATE ChamCong SET MaNV=@b, MaCa=@c, Ngay=@d, TrangThai=@e WHERE MaChamCong=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaChamCong);
                cmd.Parameters.AddWithValue("@b", obj.MaNV);
                cmd.Parameters.AddWithValue("@c", obj.MaCa);
                cmd.Parameters.AddWithValue("@d", obj.Ngay);
                cmd.Parameters.AddWithValue("@e", obj.TrangThai);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maChamCong)
        {
            string query = "DELETE FROM ChamCong WHERE MaChamCong=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maChamCong);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
