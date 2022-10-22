using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
    public class DLibro
    {
        public static DataTable ObtenLibros()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_Listar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static string BuscarNombreLibro(string NombreLibro)
        {
            SqlConnection conn = null;
            string Rpta = "";

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_ExisteNombre", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = NombreLibro;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(parExiste.Value);
            } 
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return Rpta;
        }

        public static string BuscarISBN(string ISBN)
        {
            SqlConnection conn = null;
            string Rpta = "";

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_ExisteISBN", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = ISBN;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(parExiste.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return Rpta;
        }

        

        public static string Agregar(Libro libro) {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                // insertar

                comando.Parameters.AddWithValue("@ISBN", libro.pISBN);
                comando.Parameters.AddWithValue("@NombreLibro", libro.pNombreLibro);
                comando.Parameters.AddWithValue("@Autor", libro.pAutorL);
                comando.Parameters.AddWithValue("@Existencias", libro.pExistencia);
                comando.Parameters.AddWithValue("@Editorial", libro.pEditorial);
                comando.Parameters.AddWithValue("@Consulta", libro.pConsulta);
                comando.Parameters.AddWithValue("@TipoPrestamo", libro.pPrestamo);

                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch(Exception EX)
            {
                throw EX;
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return Rpta;
            }
        }
    }


