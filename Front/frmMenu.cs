using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Front
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnConsultaLibro_Click(object sender, EventArgs e)
        {
            frmConsultaLibro consultaLibro = new frmConsultaLibro();
            consultaLibro.ShowDialog();
        }

        private void btnAgregarLibros_Click(object sender, EventArgs e)
        {
            frmAgregarLibro agregarLibro = new frmAgregarLibro();
            agregarLibro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConsultaLibroIND consultaLibroIND = new frmConsultaLibroIND();
            consultaLibroIND.Show();
        }

        private void btnAgregaPrestamo_Click(object sender, EventArgs e)
        {
            frmAgregarPrestamos agregarPrestamos = new frmAgregarPrestamos();
            agregarPrestamos.ShowDialog();
        }
    }
}
