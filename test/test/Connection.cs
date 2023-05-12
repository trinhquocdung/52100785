using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test
{
    class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-O6PQS3PT\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
