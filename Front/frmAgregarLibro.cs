using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Entidades;
using Biblioteca.Negocio;


namespace Biblioteca.Front
{
    public partial class frmAgregarLibro : Form
    {
        public frmAgregarLibro()
        {
            InitializeComponent();
            cmbEditorial.SelectedIndex = 0;
        }

        public void LimpiarCampos()
        {
            txtAutor.Text = "";
            txtExistencia.Text = "";
            txtISBN.Text = "";
            txtNombreLibro.Text = "";
            cmbEditorial.SelectedIndex = 0;
            rbInterno.Checked = true;
            checkAlumnos.Checked = true;
            checkMaestros.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validaTexto(txtISBN.Text) && validaTexto(txtNombreLibro.Text) &&
                validaTexto(txtExistencia.Text) &&
                validaTexto(txtAutor.Text))
            {
                string ISBN = txtISBN.Text;
                string nombreLibro = txtNombreLibro.Text;
                string respuesta = "";

                try
                {
                    //buscar por nombre CAMBIAR
                    respuesta = NLibro.BuscarNombreLibro(nombreLibro);
                    if (respuesta.Equals("YA EXISTE"))
                    {
                        //AQUI PUEDE USARSE ERRORP
                        MessageBox.Show("Nombre de libro duplicado");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                    return;
                }

                string autor = txtAutor.Text;
                string editorial = cmbEditorial.SelectedItem.ToString();
                byte existencia = Convert.ToByte(txtExistencia.Text);
                bool consulta;
                char prestamo='A';

                if (rbGeneral.Checked)
                {
                    consulta = true;
                }
                else
                {
                    consulta = false;
                }

                if (checkAlumnos.Checked)
                {
                    prestamo = 'A';
                } else if (checkMaestros.Checked)
                {
                    prestamo = 'M';
                } else if(checkMaestros.Checked && checkAlumnos.Checked)
                {
                    prestamo = 'D';
                }

                Libro libro = new Libro(ISBN, nombreLibro, autor, existencia, editorial, consulta, prestamo);

                try
                {
                    // Obtener la respuesta del Negocio
                    respuesta = NLibro.Agregar(libro);
                    if (respuesta.Equals("OK"))
                    {
                        MessageBox.Show("Libro agregado");
                        LimpiarCampos();
                    }
                    if (respuesta.Equals("YA EXISTE"))
                    {
                        MessageBox.Show("ISBN ya existe");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                    return;
                }
                // falta limpiar componentes LISTO
            }
            MessageBox.Show("No puedes dejar en blanco los campos.", "Mensaje",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool validaTexto(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena) || string.IsNullOrEmpty(cadena))
                return false;

            return true;
        }

        private void txtISBN_Validated(object sender, EventArgs e)
        {
            string dato = txtISBN.Text;

            if (validaTexto(dato))
            {
                errorProvider1.SetError(txtISBN, "");
            }
            else
            {
                errorProvider1.SetError(txtISBN, "No puedes dejar vacio este campo");
                txtISBN.Focus();
            }
        }

        private void txtNombreLibro_Validated(object sender, EventArgs e)
        {
            string dato = txtNombreLibro.Text;

            if (validaTexto(dato))
            {
                errorProvider1.SetError(txtNombreLibro, "");
            }
            else
            {
                errorProvider1.SetError(txtNombreLibro, "No puedes dejar vacio este campo");
                txtNombreLibro.Focus();
            }
        }

        private void txtAutor_Validated(object sender, EventArgs e)
        {
            string dato = txtAutor.Text;

            if (validaTexto(dato))
            {
                errorProvider1.SetError(txtAutor, "");
            }
            else
            {
                errorProvider1.SetError(txtAutor, "No puedes dejar vacio este campo");
                txtAutor.Focus();
            }
        }

        private void txtExistencia_Validated(object sender, EventArgs e)
        {
            string dato = txtExistencia.Text;

            if (validaTexto(dato))
            {
                errorProvider1.SetError(txtExistencia, "");
            }
            else
            {
                errorProvider1.SetError(txtExistencia, "No puedes dejar vacio este campo");
                txtExistencia.Focus();
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
