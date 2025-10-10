using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class NhapXuatKhoDAO
    {
        public List<NhapXuatKhoDTO> LayTatCa()
        {
            var list = new List<NhapXuatKhoDTO>();
            string query = "SELECT * FROM NhapXuatKho";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new NhapXuatKhoDTO
                        {
                            MaNXK = r["MaNXK"].ToString(),
                            MaMH = r["MaMH"].ToString(),
                            LoaiGiaoDich = r["LoaiGiaoDich"].ToString(),
                            SoLuong = Convert.ToInt32(r["SoLuong"]),
                            NgayGiaoDich = Convert.ToDateTime(r["NgayGiaoDich"]),
                            MaNV = r["MaNV"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(NhapXuatKhoDTO obj)
        {
            string query = "INSERT INTO NhapXuatKho(MaNXK, MaMH, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNV) VALUES(@a,@b,@c,@d,@e,@f)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaNXK);
                cmd.Parameters.AddWithValue("@b", obj.MaMH);
                cmd.Parameters.AddWithValue("@c", obj.LoaiGiaoDich);
                cmd.Parameters.AddWithValue("@d", obj.SoLuong);
                cmd.Parameters.AddWithValue("@e", obj.NgayGiaoDich);
                cmd.Parameters.AddWithValue("@f", obj.MaNV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(NhapXuatKhoDTO obj)
        {
            string query = "UPDATE NhapXuatKho SET MaMH=@b, LoaiGiaoDich=@c, SoLuong=@d, NgayGiaoDich=@e, MaNV=@f WHERE MaNXK=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaNXK);
                cmd.Parameters.AddWithValue("@b", obj.MaMH);
                cmd.Parameters.AddWithValue("@c", obj.LoaiGiaoDich);
                cmd.Parameters.AddWithValue("@d", obj.SoLuong);
                cmd.Parameters.AddWithValue("@e", obj.NgayGiaoDich);
                cmd.Parameters.AddWithValue("@f", obj.MaNV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maNXK)
        {
            string query = "DELETE FROM NhapXuatKho WHERE MaNXK=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maNXK);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
