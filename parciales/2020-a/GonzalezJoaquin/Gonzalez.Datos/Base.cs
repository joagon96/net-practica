using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Gonzalez.Datos
{
    public class Base
    {
        private SqlConnection _sqlConn;
        public SqlConnection sqlConn
        {
            get { return _sqlConn; }
            set { _sqlConn = value; }
        }

        public void OpenConnection()
        {
            string ConnString = ConfigurationManager.ConnectionStrings[conKey].ConnectionString;
            sqlConn = new SqlConnection(ConnString);
            sqlConn.Open();
        }

        public void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }

        const string conKey = "connStringExpress";
    }
}
