using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class GoiMonDAO
    {
        public List<GoiMonDTO> LayTatCa()
        {
            var list = new List<GoiMonDTO>();
            string query = "SELECT * FROM GoiMon";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new GoiMonDTO
                        {
                            MaGoiMon = r["MaGoiMon"].ToString(),
                            MaDatBan = r["MaDatBan"].ToString(),
                            MaNVGoi = r["MaNVGoi"] == DBNull.Value ? null : r["MaNVGoi"].ToString(),
                            ThoiGianGoi = Convert.ToDateTime(r["ThoiGianGoi"]),
                            TrangThai = r["TrangThai"].ToString(),
                            GhiChu = r["GhiChu"] == DBNull.Value ? null : r["GhiChu"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(GoiMonDTO obj)
        {
            string query = "INSERT INTO GoiMon(MaGoiMon, MaDatBan, MaNVGoi, ThoiGianGoi, TrangThai, GhiChu) VALUES(@a,@b,@c,@d,@e,@f)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaGoiMon);
                cmd.Parameters.AddWithValue("@b", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@c", (object)obj.MaNVGoi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d", obj.ThoiGianGoi);
                cmd.Parameters.AddWithValue("@e", obj.TrangThai);
                cmd.Parameters.AddWithValue("@f", (object)obj.GhiChu ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(GoiMonDTO obj)
        {
            string query = "UPDATE GoiMon SET MaDatBan=@b, MaNVGoi=@c, ThoiGianGoi=@d, TrangThai=@e, GhiChu=@f WHERE MaGoiMon=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaGoiMon);
                cmd.Parameters.AddWithValue("@b", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@c", (object)obj.MaNVGoi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d", obj.ThoiGianGoi);
                cmd.Parameters.AddWithValue("@e", obj.TrangThai);
                cmd.Parameters.AddWithValue("@f", (object)obj.GhiChu ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maGoiMon)
        {
            string query = "DELETE FROM GoiMon WHERE MaGoiMon=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maGoiMon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
