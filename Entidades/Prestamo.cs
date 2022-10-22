using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Prestamo
    {
        private int ClavePrestamo;
        private int ISBNPrestamo;
        private string NombreUsuario;
        private char TipoUsuario;

        public Prestamo(int clavePrestamo, int isbnPrestamo, string nombreUsuario, char tipoUsuario)
        {
            ClavePrestamo = clavePrestamo;
            ISBNPrestamo = isbnPrestamo;
            NombreUsuario = nombreUsuario;
            TipoUsuario = tipoUsuario;
        }

        public int pClavePres
        {
            get
            {
                return ClavePrestamo;
            }
        }

        public int pISBNPrestamo
        {
            get
            {
                return ISBNPrestamo;
            }
        }

        public string pNombreUsuario
        {
            get
            {
                return NombreUsuario;
            }
        }
        public char pTipoUsuario
        {
            get
            {
                return TipoUsuario;
            }
        }
    }
}
