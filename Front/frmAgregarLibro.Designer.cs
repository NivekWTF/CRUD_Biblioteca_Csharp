
namespace Biblioteca.Front
{
    partial class frmAgregarLibro
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
            this.components = new System.ComponentModel.Container();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbpPrestarA = new System.Windows.Forms.GroupBox();
            this.checkAlumnos = new System.Windows.Forms.CheckBox();
            this.checkMaestros = new System.Windows.Forms.CheckBox();
            this.gpbUso = new System.Windows.Forms.GroupBox();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbInterno = new System.Windows.Forms.RadioButton();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.lblAutores = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblDatosLibro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbpPrestarA.SuspendLayout();
            this.gpbUso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtISBN.Location = new System.Drawing.Point(64, 119);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 27;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            this.txtISBN.Validated += new System.EventHandler(this.txtISBN_Validated);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSalir.Location = new System.Drawing.Point(589, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 41);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnConsultar.Location = new System.Drawing.Point(589, 326);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 41);
            this.btnConsultar.TabIndex = 42;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.Location = new System.Drawing.Point(589, 269);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 41);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGuardar.Location = new System.Drawing.Point(589, 212);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 41);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbpPrestarA
            // 
            this.gbpPrestarA.Controls.Add(this.checkAlumnos);
            this.gbpPrestarA.Controls.Add(this.checkMaestros);
            this.gbpPrestarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpPrestarA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbpPrestarA.Location = new System.Drawing.Point(302, 281);
            this.gbpPrestarA.Name = "gbpPrestarA";
            this.gbpPrestarA.Size = new System.Drawing.Size(200, 130);
            this.gbpPrestarA.TabIndex = 39;
            this.gbpPrestarA.TabStop = false;
            this.gbpPrestarA.Text = "Prestar a:";
            // 
            // checkAlumnos
            // 
            this.checkAlumnos.AutoSize = true;
            this.checkAlumnos.Checked = true;
            this.checkAlumnos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkAlumnos.Location = new System.Drawing.Point(17, 76);
            this.checkAlumnos.Name = "checkAlumnos";
            this.checkAlumnos.Size = new System.Drawing.Size(87, 24);
            this.checkAlumnos.TabIndex = 1;
            this.checkAlumnos.Text = "Alumnos";
            this.checkAlumnos.UseVisualStyleBackColor = true;
            // 
            // checkMaestros
            // 
            this.checkMaestros.AutoSize = true;
            this.checkMaestros.Checked = true;
            this.checkMaestros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaestros.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkMaestros.Location = new System.Drawing.Point(17, 30);
            this.checkMaestros.Name = "checkMaestros";
            this.checkMaestros.Size = new System.Drawing.Size(91, 24);
            this.checkMaestros.TabIndex = 0;
            this.checkMaestros.Text = "Maestros";
            this.checkMaestros.UseVisualStyleBackColor = true;
            // 
            // gpbUso
            // 
            this.gpbUso.Controls.Add(this.rbGeneral);
            this.gpbUso.Controls.Add(this.rbInterno);
            this.gpbUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gpbUso.Location = new System.Drawing.Point(68, 278);
            this.gpbUso.Name = "gpbUso";
            this.gpbUso.Size = new System.Drawing.Size(160, 133);
            this.gpbUso.TabIndex = 38;
            this.gpbUso.TabStop = false;
            this.gpbUso.Text = "Para uso:";
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGeneral.Location = new System.Drawing.Point(12, 79);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(84, 24);
            this.rbGeneral.TabIndex = 1;
            this.rbGeneral.Text = "General";
            this.rbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbInterno
            // 
            this.rbInterno.AutoSize = true;
            this.rbInterno.Checked = true;
            this.rbInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInterno.Location = new System.Drawing.Point(12, 33);
            this.rbInterno.Name = "rbInterno";
            this.rbInterno.Size = new System.Drawing.Size(78, 24);
            this.rbInterno.TabIndex = 0;
            this.rbInterno.TabStop = true;
            this.rbInterno.Text = "Interno";
            this.rbInterno.UseVisualStyleBackColor = true;
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Items.AddRange(new object[] {
            "Troya",
            "Planeta",
            "UwU"});
            this.cmbEditorial.Location = new System.Drawing.Point(492, 119);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(172, 21);
            this.cmbEditorial.TabIndex = 29;
            // 
            // txtExistencia
            // 
            this.txtExistencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExistencia.Location = new System.Drawing.Point(331, 212);
            this.txtExistencia.MaxLength = 2;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(102, 20);
            this.txtExistencia.TabIndex = 37;
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            this.txtExistencia.Validated += new System.EventHandler(this.txtExistencia_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(328, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Existencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(489, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Editorial";
            // 
            // txtAutor
            // 
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutor.Location = new System.Drawing.Point(68, 212);
            this.txtAutor.MaxLength = 13;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(216, 20);
            this.txtAutor.TabIndex = 30;
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            this.txtAutor.Validated += new System.EventHandler(this.txtAutor_Validated);
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreLibro.Location = new System.Drawing.Point(229, 121);
            this.txtNombreLibro.MaxLength = 20;
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(216, 20);
            this.txtNombreLibro.TabIndex = 28;
            this.txtNombreLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLibro_KeyPress);
            this.txtNombreLibro.Validated += new System.EventHandler(this.txtNombreLibro_Validated);
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAutores.Location = new System.Drawing.Point(77, 179);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(69, 18);
            this.lblAutores.TabIndex = 34;
            this.lblAutores.Text = "Autor(es)";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLibro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNombreLibro.Location = new System.Drawing.Point(242, 90);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(122, 18);
            this.lblNombreLibro.TabIndex = 33;
            this.lblNombreLibro.Text = "Nombre del Libro";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblISBN.Location = new System.Drawing.Point(61, 90);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(42, 18);
            this.lblISBN.TabIndex = 32;
            this.lblISBN.Text = "ISBN";
            // 
            // lblDatosLibro
            // 
            this.lblDatosLibro.AutoSize = true;
            this.lblDatosLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosLibro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatosLibro.Location = new System.Drawing.Point(338, 30);
            this.lblDatosLibro.Name = "lblDatosLibro";
            this.lblDatosLibro.Size = new System.Drawing.Size(150, 24);
            this.lblDatosLibro.TabIndex = 31;
            this.lblDatosLibro.Text = "Datos del Libro";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbpPrestarA);
            this.Controls.Add(this.gpbUso);
            this.Controls.Add(this.cmbEditorial);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblDatosLibro);
            this.Name = "frmAgregarLibro";
            this.Text = "Agregar Libros";
            this.gbpPrestarA.ResumeLayout(false);
            this.gbpPrestarA.PerformLayout();
            this.gpbUso.ResumeLayout(false);
            this.gpbUso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbpPrestarA;
        private System.Windows.Forms.CheckBox checkAlumnos;
        private System.Windows.Forms.CheckBox checkMaestros;
        private System.Windows.Forms.GroupBox gpbUso;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbInterno;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblDatosLibro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}