using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Libro
    {
        private string ISBN;
        private string NombreLibro;
        private string Autor;
        private byte Existencia;
        private string Editorial;
        private bool Consulta;
        private char Prestamo;

        public Libro(string isbn, string nombreLibro, string autor,byte existencia, string editorial, bool consulta, char prestamo)
        {
            ISBN = isbn;
            NombreLibro = nombreLibro;
            Autor = autor;
            Existencia = existencia;
            Editorial = editorial;
            Consulta = consulta;
            Prestamo = prestamo;
        }
        public string pISBN
        {
            get
            {
                return ISBN;
            }
        }

        public string pNombreLibro
        {
            get
            {
                return NombreLibro;
            }
        }

        public string pAutorL
        {
            get
            {
                return Autor;
            }
        }

        public byte pExistencia
        {
            get
            {
                return Existencia;
            }
        }

        public string pEditorial
        {
            get
            {
                return Editorial;
            }
        }

        public bool pConsulta
        {
            get
            {
                return Consulta;
            }
        }

        public char pPrestamo
        {
            get
            {
                return Prestamo;
            }
        }
    }
}
