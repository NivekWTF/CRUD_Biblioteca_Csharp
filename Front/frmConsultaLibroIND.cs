using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Front
{
    public partial class frmConsultaLibroIND : Form
    {
        public frmConsultaLibroIND()
        {
            InitializeComponent();
        }
        DataTable tabla;

        private void frmConsultaLibroIND_Load(object sender, EventArgs e)
        {
            try
            {
                tabla = NLibro.ObtenLibros();
                cmbISBN.DataSource = tabla;
                this.cmbISBN.DisplayMember = "ISBN";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }
        }

        private void cmbISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isbnSelccionado = cmbISBN.GetItemText(cmbISBN.SelectedItem);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string isbnTabla = tabla.Rows[i][0].ToString();
                if (isbnTabla.Equals(isbnSelccionado))
                {
                    dtgIndividual.Rows.Clear();
                    string nombreLibro = tabla.Rows[i][1].ToString();
                    dtgIndividual.Rows.Add(tabla.Rows[i][1].ToString(), tabla.Rows[i][2].ToString());
                }
            }
        }
    }
}
