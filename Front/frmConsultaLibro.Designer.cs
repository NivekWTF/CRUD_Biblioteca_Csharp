namespace Biblioteca.Front
{
    partial class frmConsultaLibro
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
            this.dtgLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLibros
            // 
            this.dtgLibros.AllowUserToAddRows = false;
            this.dtgLibros.AllowUserToDeleteRows = false;
            this.dtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgLibros.Location = new System.Drawing.Point(0, 0);
            this.dtgLibros.Name = "dtgLibros";
            this.dtgLibros.ReadOnly = true;
            this.dtgLibros.Size = new System.Drawing.Size(900, 450);
            this.dtgLibros.TabIndex = 0;
            // 
            // frmConsultaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.dtgLibros);
            this.Name = "frmConsultaLibro";
            this.Text = "Consulta Libros";
            this.Load += new System.EventHandler(this.frmConsultaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLibros;
    }
}