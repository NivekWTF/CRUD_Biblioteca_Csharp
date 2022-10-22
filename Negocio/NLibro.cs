using System;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
    public class NLibro
    {
        public static DataTable ObtenLibros()
        {
            return DLibro.ObtenLibros();
        }

        public static string BuscarNombreLibro(string nombreLibro)
        {
            string respuesta = "NO EXISTE";
            string retorno = DLibro.BuscarNombreLibro(nombreLibro);

            if (retorno.Equals("1"))
                respuesta = "YA EXISTE";
            return respuesta;


        }

        public static string Agregar(Libro libro)
        {
            //validar que el libro No exista
            //buscandolo en el Datos por medio de 'existe'
            string existe = DLibro.BuscarISBN(libro.pISBN);
            //si no existe
            //se agrega invocando el agregar de 'Datos'
            if (existe.Equals("0"))
            {
                return DLibro.Agregar(libro);
            }
            else
            {
                return "YA EXISTE";
            }
        }
    }
}
