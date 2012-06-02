using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace carandrivermanagesystem
{
    class Connect
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = null;
            String strCon = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            try
            {
                conn = new SqlConnection(strCon);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conn;
        }
    }
}
