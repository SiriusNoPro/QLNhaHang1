using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
   public class ThongBaoDAO
    {
        public List<ThongBaoDTO> LayTatCa()
        {
            var list = new List<ThongBaoDTO>();
            string query = "SELECT * FROM ThongBao";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new ThongBaoDTO
                        {
                            MaThongBao = r["MaThongBao"].ToString(),
                            LoaiThongBao = r["LoaiThongBao"].ToString(),
                            NoiDung = r["NoiDung"].ToString(),
                            MaNVTo = r["MaNVTo"] == DBNull.Value ? null : r["MaNVTo"].ToString(),
                            DaDoc = Convert.ToBoolean(r["DaDoc"]),
                            ThoiGian = Convert.ToDateTime(r["ThoiGian"]),
                            MaGoiMon = r["MaGoiMon"] == DBNull.Value ? null : r["MaGoiMon"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(ThongBaoDTO obj)
        {
            string query = "INSERT INTO ThongBao(MaThongBao, LoaiThongBao, NoiDung, MaNVTo, DaDoc, ThoiGian, MaGoiMon) VALUES(@a,@b,@c,@d,@e,@f,@g)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaThongBao);
                cmd.Parameters.AddWithValue("@b", obj.LoaiThongBao);
                cmd.Parameters.AddWithValue("@c", obj.NoiDung);
                cmd.Parameters.AddWithValue("@d", (object)obj.MaNVTo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", obj.DaDoc);
                cmd.Parameters.AddWithValue("@f", obj.ThoiGian);
                cmd.Parameters.AddWithValue("@g", (object)obj.MaGoiMon ?? DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(ThongBaoDTO obj)
        {
            string query = "UPDATE ThongBao SET LoaiThongBao=@b, NoiDung=@c, MaNVTo=@d, DaDoc=@e, ThoiGian=@f, MaGoiMon=@g WHERE MaThongBao=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaThongBao);
                cmd.Parameters.AddWithValue("@b", obj.LoaiThongBao);
                cmd.Parameters.AddWithValue("@c", obj.NoiDung);
                cmd.Parameters.AddWithValue("@d", (object)obj.MaNVTo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@e", obj.DaDoc);
                cmd.Parameters.AddWithValue("@f", obj.ThoiGian);
                cmd.Parameters.AddWithValue("@g", (object)obj.MaGoiMon ?? DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maThongBao)
        {
            string query = "DELETE FROM ThongBao WHERE MaThongBao=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maThongBao);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
