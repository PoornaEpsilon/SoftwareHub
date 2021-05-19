using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
using SoftwareHub.Models;

namespace SoftwareHub.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=epsilondb;Integrated Security=True");
        public int LoginCheck(NewUserClass nu)
        {
            SqlCommand com = new SqlCommand("Sh_Login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@username", nu.username);
            com.Parameters.AddWithValue("@password", nu.password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }
    }
}
