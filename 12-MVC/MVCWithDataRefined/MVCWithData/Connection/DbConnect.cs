using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCWithData.Connection
{
    public static class DbConnect
    {
        private static SqlConnection con;
        public static SqlConnection GetConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            }
            return con;
        }
    }
}