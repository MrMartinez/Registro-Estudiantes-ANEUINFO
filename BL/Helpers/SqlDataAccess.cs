﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL.Helpers
{
    public class SqlDataAccess
    {
        string connectionString = string.Empty;
        public SqlDataAccess()
        {
            try
            {
                connectionString = SingletonConnection.Instance._connection;
            }
            catch (Exception)
            {

                MessageBox.Show("Error conectando a la Base de Datos");
            }
        }


        //Para el select
        public DataSet executeQuery(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(commandText, conn))
            {
                DataSet ds = new DataSet();
                cmd.CommandType = commandType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conn.Close();
                return ds;
            }

        }

        public bool executeNonQuery(string commandText, CommandType commandType, params SqlParameter[] commandParameters)
        {
            bool b = false;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(commandText, conn))
            {
                conn.Open();
                cmd.CommandText = commandText;
                cmd.Parameters.AddRange(commandParameters);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    b = true;
                    MessageBox.Show("Registro ingresado exitosamente");
                }
                else
                {
                    b = false;
                    MessageBox.Show("Error guardando registro");

                }
            }
            return b;

        }





    }
}
