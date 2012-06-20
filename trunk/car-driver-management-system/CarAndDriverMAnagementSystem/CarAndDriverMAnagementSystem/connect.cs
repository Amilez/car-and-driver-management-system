using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace CarAndDriverMAnagementSystem
{
    class connect
    {
        public static SqlConnection Getconect(){
            SqlConnection conn = null;
            String strCon = ConfigurationManager.ConnectionStrings["const"].ConnectionString;
            try
            {
                conn = new SqlConnection(strCon);
            }
            catch(SqlException ex){
                Console.WriteLine(ex.Message);
            }
            return conn;
        }
    }
}
