
namespace Biblioteca.Front
{
    partial class frmMenu
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
            this.btnConsultaLibro = new System.Windows.Forms.Button();
            this.btnAgregarLibros = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregaPrestamo = new System.Windows.Forms.Button();
            this.btnConsultaPrestamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaLibro
            // 
            this.btnConsultaLibro.Location = new System.Drawing.Point(179, 179);
            this.btnConsultaLibro.Name = "btnConsultaLibro";
            this.btnConsultaLibro.Size = new System.Drawing.Size(194, 55);
            this.btnConsultaLibro.TabIndex = 1;
            this.btnConsultaLibro.Text = "Consultar Libros";
            this.btnConsultaLibro.UseVisualStyleBackColor = true;
            this.btnConsultaLibro.Click += new System.EventHandler(this.btnConsultaLibro_Click);
            // 
            // btnAgregarLibros
            // 
            this.btnAgregarLibros.Location = new System.Drawing.Point(179, 83);
            this.btnAgregarLibros.Name = "btnAgregarLibros";
            this.btnAgregarLibros.Size = new System.Drawing.Size(194, 55);
            this.btnAgregarLibros.TabIndex = 0;
            this.btnAgregarLibros.Text = "Agregar Libros";
            this.btnAgregarLibros.UseVisualStyleBackColor = true;
            this.btnAgregarLibros.Click += new System.EventHandler(this.btnAgregarLibros_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consulta Ind";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregaPrestamo
            // 
            this.btnAgregaPrestamo.Location = new System.Drawing.Point(404, 83);
            this.btnAgregaPrestamo.Name = "btnAgregaPrestamo";
            this.btnAgregaPrestamo.Size = new System.Drawing.Size(194, 55);
            this.btnAgregaPrestamo.TabIndex = 3;
            this.btnAgregaPrestamo.Text = "Agregar Prestamo";
            this.btnAgregaPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregaPrestamo.Click += new System.EventHandler(this.btnAgregaPrestamo_Click);
            // 
            // btnConsultaPrestamos
            // 
            this.btnConsultaPrestamos.Location = new System.Drawing.Point(404, 179);
            this.btnConsultaPrestamos.Name = "btnConsultaPrestamos";
            this.btnConsultaPrestamos.Size = new System.Drawing.Size(194, 55);
            this.btnConsultaPrestamos.TabIndex = 4;
            this.btnConsultaPrestamos.Text = "Consultar Prestamos";
            this.btnConsultaPrestamos.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultaPrestamos);
            this.Controls.Add(this.btnAgregaPrestamo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarLibros);
            this.Controls.Add(this.btnConsultaLibro);
            this.Name = "frmMenu";
            this.Text = "Biblioteca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaLibro;
        private System.Windows.Forms.Button btnAgregarLibros;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregaPrestamo;
        private System.Windows.Forms.Button btnConsultaPrestamos;
    }
}