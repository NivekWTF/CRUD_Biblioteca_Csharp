
namespace Biblioteca.Front
{
    partial class frmConsultaLibroIND
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbISBN = new System.Windows.Forms.ComboBox();
            this.dtgIndividual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIndividual)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbISBN
            // 
            this.cmbISBN.FormattingEnabled = true;
            this.cmbISBN.Location = new System.Drawing.Point(92, 76);
            this.cmbISBN.Name = "cmbISBN";
            this.cmbISBN.Size = new System.Drawing.Size(121, 21);
            this.cmbISBN.TabIndex = 0;
            this.cmbISBN.SelectedIndexChanged += new System.EventHandler(this.cmbISBN_SelectedIndexChanged);
            // 
            // dtgIndividual
            // 
            this.dtgIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIndividual.Location = new System.Drawing.Point(12, 149);
            this.dtgIndividual.Name = "dtgIndividual";
            this.dtgIndividual.Size = new System.Drawing.Size(776, 204);
            this.dtgIndividual.TabIndex = 1;
            // 
            // frmConsultaLibroIND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgIndividual);
            this.Controls.Add(this.cmbISBN);
            this.Name = "frmConsultaLibroIND";
            this.Text = "Consulta Individual (Libro)";
            this.Load += new System.EventHandler(this.frmConsultaLibroIND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIndividual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbISBN;
        private System.Windows.Forms.DataGridView dtgIndividual;
    }
}