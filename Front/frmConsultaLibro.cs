using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Front
{
    public partial class frmConsultaLibro : Form
    {
        public frmConsultaLibro()
        {
            InitializeComponent();
            
        }

        private void frmConsultaLibro_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NLibro.ObtenLibros();
                this.dtgLibros.DataSource = data;
                dtgLibros.Columns[1].Width = 225;
                dtgLibros.Columns[2].Width = 140;
                dtgLibros.Columns[3].Width = 100;
                dtgLibros.Columns[5].Width = 110;
                dtgLibros.Columns[6].Width = 80;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
