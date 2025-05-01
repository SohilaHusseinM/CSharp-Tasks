using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Day13
{

    static class ConnectionBase
    {
        public static SqlConnection SqlCN;

        static ConnectionBase()
        {
            SqlCN = new SqlConnection();
            SqlCN.ConnectionString = ConfigurationManager.ConnectionStrings["pubsCN"].ConnectionString;
        }

    }
}
