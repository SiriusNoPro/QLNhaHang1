using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
namespace QLNhaHang.DAO
{
    public class DatabaseHelper
    {
		private static readonly string connectionString = "Data Source=. ;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static SqlConnection GetConnection()
        {
           
            return new SqlConnection(connectionString);
        }

		public static DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					if (parameters != null)
					{
						foreach (var p in parameters)
							cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
					}
					using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
					{
						DataTable table = new DataTable();
						adapter.Fill(table);
						return table;
					}
				}
			}
		}

		public static int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					if (parameters != null)
					{
						foreach (var p in parameters)
							cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
					}
					return cmd.ExecuteNonQuery();
				}
			}
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
							cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}

