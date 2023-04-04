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
        private SqlConnection _SqlConn;
        public SqlConnection SqlConn { get { return _SqlConn; } set { _SqlConn = value; } }

        public void OpenConnection()
        {
            string ConnString = ConfigurationManager.ConnectionStrings[ConnKey].ConnectionString;
            this.SqlConn = new SqlConnection(ConnString);
            this.SqlConn.Open();
        }

        public void CloseConnection()
        {
            this.SqlConn.Close();
            this.SqlConn = null;
        }

        const string ConnKey = "ConnStringNet";
    }
}
