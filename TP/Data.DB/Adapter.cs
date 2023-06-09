﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.DB
{
    public class Adapter
    {
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");

        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringExpress";

        private SqlConnection _sqlConn;
        public SqlConnection sqlConn
        {
            get { return _sqlConn; }
            set { _sqlConn = value; }
        }


        protected void OpenConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            sqlConn = new SqlConnection(connString);
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
