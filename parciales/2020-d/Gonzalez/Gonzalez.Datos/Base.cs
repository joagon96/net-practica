using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Gonzalez.Datos
{
    public class Base
    {
        const string conKey = "connStringNet";

        private SqlConnection _SqlConn;
        public SqlConnection SqlConn
        {
            get { return _SqlConn; }
            set { _SqlConn = value; }
        }

        public void OpenConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings[conKey].ConnectionString;
            SqlConn = new SqlConnection(connString);
            SqlConn.Open();
        }

        public void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
        }
    }
}
