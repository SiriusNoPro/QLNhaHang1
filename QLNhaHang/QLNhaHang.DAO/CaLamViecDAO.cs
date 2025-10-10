using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class CaLamViecDAO
    {
        public List<CaLamViecDTO> LayTatCa()
        {
            var list = new List<CaLamViecDTO>();
            string query = "SELECT * FROM CaLamViec";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new CaLamViecDTO
                        {
                            MaCa = r["MaCa"].ToString(),
                            TenCa = r["TenCa"].ToString(),
                            GioBatDau = (TimeSpan)r["GioBatDau"],
                            GioKetThuc = (TimeSpan)r["GioKetThuc"]
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(CaLamViecDTO obj)
        {
            string query = "INSERT INTO CaLamViec(MaCa, TenCa, GioBatDau, GioKetThuc) VALUES(@a,@b,@c,@d)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaCa);
                cmd.Parameters.AddWithValue("@b", obj.TenCa);
                cmd.Parameters.AddWithValue("@c", obj.GioBatDau);
                cmd.Parameters.AddWithValue("@d", obj.GioKetThuc);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(CaLamViecDTO obj)
        {
            string query = "UPDATE CaLamViec SET TenCa=@b, GioBatDau=@c, GioKetThuc=@d WHERE MaCa=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaCa);
                cmd.Parameters.AddWithValue("@b", obj.TenCa);
                cmd.Parameters.AddWithValue("@c", obj.GioBatDau);
                cmd.Parameters.AddWithValue("@d", obj.GioKetThuc);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maCa)
        {
            string query = "DELETE FROM CaLamViec WHERE MaCa=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maCa);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
