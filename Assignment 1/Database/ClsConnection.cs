using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment_1.Database
{
    public class ClsConnection
    {
        static SqlConnection my_connection = null;

        internal static SqlConnection Conn()
        {
            try
            {
                if(my_connection == null)
                {
                    my_connection = new SqlConnection(@"Data Source=LAPTOP-TE7UBH4E;Initial Catalog=DucatTraining;Integrated Security=True");
                    my_connection.Open();
                }
                if (my_connection.State == System.Data.ConnectionState.Closed)
                {
                    my_connection.Open();
                }
                return my_connection;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}