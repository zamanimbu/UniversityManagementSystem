using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace UniversityManagementAPP.DAL
{
    public class Gateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["courseResultDBConnection"].ConnectionString;
        public SqlConnection Connection { get; set; }
        public SqlDataReader Reader { get; set; }
        public SqlCommand Command { get; set; }
        public string Query { get; set; }


        public Gateway()
        {
            Connection = new SqlConnection(connectionString);
            Command = new SqlCommand();
            Command.Connection = Connection;
        }
    }
}