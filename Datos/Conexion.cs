using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Biblioteca.Datos
{
    public class Conexion
    {
        public static SqlConnection CrearConexion() {
            string strConn = GetConnectionString();
        SqlConnection conn;
            // no se si va el try
            try
            {
                conn = LibreriaBD.UsoBD.ConectaBD(strConn);
            }
            catch (Exception ex)
            {
                conn = null;
                throw ex;

            }
            return conn;
        
        }

        private static string GetConnectionString()
        {
            string strConn = "";

            try
            {
                strConn = ConfigurationManager.ConnectionStrings["conStrBD"].ConnectionString;
            }
            catch (Exception)
            {
               throw;
            }
            return strConn;
        }
    }
}
