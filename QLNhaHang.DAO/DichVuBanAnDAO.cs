using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhaHang.DTO;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class DichVuBanAnDAO
    {
        public List<DichVuBanAnDTO> LayTatCa()
        {
            var list = new List<DichVuBanAnDTO>();
            string query = "SELECT * FROM DichVuBanAn";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new DichVuBanAnDTO
                        {
                            MaDV = r["MaDV"].ToString(),
                            MaDatBan = r["MaDatBan"].ToString(),
                            MaMH = r["MaMH"].ToString(),
                            SoLuong = Convert.ToInt32(r["SoLuong"]),
                            GiaTaiThoiDiemDat = Convert.ToDecimal(r["GiaTaiThoiDiemDat"])
                        });
                    }
                }
            }
            return list;
        }

        public bool Them(DichVuBanAnDTO obj)
        {
            string query = "INSERT INTO DichVuBanAn(MaDV, MaDatBan, MaMH, SoLuong, GiaTaiThoiDiemDat) VALUES(@a,@b,@c,@d,@e)";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaDV);
                cmd.Parameters.AddWithValue("@b", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@c", obj.MaMH);
                cmd.Parameters.AddWithValue("@d", obj.SoLuong);
                cmd.Parameters.AddWithValue("@e", obj.GiaTaiThoiDiemDat);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CapNhat(DichVuBanAnDTO obj)
        {
            string query = "UPDATE DichVuBanAn SET MaDatBan=@b, MaMH=@c, SoLuong=@d, GiaTaiThoiDiemDat=@e WHERE MaDV=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", obj.MaDV);
                cmd.Parameters.AddWithValue("@b", obj.MaDatBan);
                cmd.Parameters.AddWithValue("@c", obj.MaMH);
                cmd.Parameters.AddWithValue("@d", obj.SoLuong);
                cmd.Parameters.AddWithValue("@e", obj.GiaTaiThoiDiemDat);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maDV)
        {
            string query = "DELETE FROM DichVuBanAn WHERE MaDV=@a";
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@a", maDV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
