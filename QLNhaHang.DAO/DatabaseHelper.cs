using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace QLNhaHang.DAO
{
    public class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=   ;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Trust Server Certificate=True";
        public static SqlConnection GetConnection()
        {
           
            return new SqlConnection(connectionString);
        }
        public static object ExecuteScalar(string query, Dictionary<string, object> parameters)
        { 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var p in parameters)
                            cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}

