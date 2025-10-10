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
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=;Initial Catalog=QuanLyNhaHang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            return new SqlConnection(connectionString);
        }
    }
}
