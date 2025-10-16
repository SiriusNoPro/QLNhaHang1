using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QLNhaHang.DTO;
namespace QLNhaHang.DAO
{
    public class LichSuTichDiemDAO
    {
        public List<LichSuTichDiemDTO> LayTatCa()
        {
            var list = new List<LichSuTichDiemDTO>();
            string query = "SELECT * FROM LichSuTichDiem";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new LichSuTichDiemDTO
                        {
                            MaLichSu = Convert.ToInt32(r["MaLichSu"]),
                            MaKH = r["MaKH"].ToString(),
                            MaHoaDon = r["MaHoaDon"] == DBNull.Value ? null : r["MaHoaDon"].ToString(),
                            NgayGiaoDich = Convert.ToDateTime(r["NgayGiaoDich"]),
                            DiemThayDoi = Convert.ToInt32(r["DiemThayDoi"]),
                            LoaiGiaoDich = r["LoaiGiaoDich"].ToString(),
                            GhiChu = r["GhiChu"] == DBNull.Value ? null : r["GhiChu"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(LichSuTichDiemDTO obj)
        {
            string query = "INSERT INTO LichSuTichDiem(MaKH, MaHoaDon, NgayGiaoDich, DiemThayDoi, LoaiGiaoDich, GhiChu) VALUES(@a,@b,@c,@d,@e,@f)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaKH);
                cmd.Parameters.AddWithValue("@b", (object)obj.MaHoaDon ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@c", obj.NgayGiaoDich);
                cmd.Parameters.AddWithValue("@d", obj.DiemThayDoi);
                cmd.Parameters.AddWithValue("@e", obj.LoaiGiaoDich);
                cmd.Parameters.AddWithValue("@f", (object)obj.GhiChu ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(int maLichSu)
        {
            string query = "DELETE FROM LichSuTichDiem WHERE MaLichSu=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maLichSu);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
