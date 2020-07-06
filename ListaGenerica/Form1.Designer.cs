namespace ListaGenerica
{
    partial class frmLista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstvEstudiante = new System.Windows.Forms.ListView();
            this.gridEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnFiltrarmat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMayoredad = new System.Windows.Forms.TextBox();
            this.txtMenoredad = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(21, 29);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(24, 67);
            this.txtMatricula.MaxLength = 5;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(61, 20);
            this.txtMatricula.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(124, 67);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(118, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(273, 67);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(120, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(444, 67);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(29, 20);
            this.txtEdad.TabIndex = 8;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbSexo.Location = new System.Drawing.Point(521, 67);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(36, 21);
            this.cmbSexo.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(587, 65);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstvEstudiante
            // 
            this.lstvEstudiante.HideSelection = false;
            this.lstvEstudiante.Location = new System.Drawing.Point(24, 113);
            this.lstvEstudiante.Name = "lstvEstudiante";
            this.lstvEstudiante.Size = new System.Drawing.Size(369, 84);
            this.lstvEstudiante.TabIndex = 11;
            this.lstvEstudiante.UseCompatibleStateImageBehavior = false;
            // 
            // gridEstudiantes
            // 
            this.gridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstudiantes.Location = new System.Drawing.Point(24, 220);
            this.gridEstudiantes.Name = "gridEstudiantes";
            this.gridEstudiantes.Size = new System.Drawing.Size(635, 183);
            this.gridEstudiantes.TabIndex = 12;
            // 
            // btnFiltrarmat
            // 
            this.btnFiltrarmat.Location = new System.Drawing.Point(412, 174);
            this.btnFiltrarmat.Name = "btnFiltrarmat";
            this.btnFiltrarmat.Size = new System.Drawing.Size(113, 23);
            this.btnFiltrarmat.TabIndex = 13;
            this.btnFiltrarmat.Text = "Filtrar por Matricula";
            this.btnFiltrarmat.UseVisualStyleBackColor = true;
            this.btnFiltrarmat.Click += new System.EventHandler(this.btnFiltrarmat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mayor Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Menor Edad";
            // 
            // txtMayoredad
            // 
            this.txtMayoredad.Location = new System.Drawing.Point(521, 110);
            this.txtMayoredad.Name = "txtMayoredad";
            this.txtMayoredad.Size = new System.Drawing.Size(54, 20);
            this.txtMayoredad.TabIndex = 16;
            // 
            // txtMenoredad
            // 
            this.txtMenoredad.Location = new System.Drawing.Point(521, 147);
            this.txtMenoredad.Name = "txtMenoredad";
            this.txtMenoredad.Size = new System.Drawing.Size(54, 20);
            this.txtMenoredad.TabIndex = 16;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(587, 145);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 17;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 449);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtMenoredad);
            this.Controls.Add(this.txtMayoredad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrarmat);
            this.Controls.Add(this.gridEstudiantes);
            this.Controls.Add(this.lstvEstudiante);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmLista";
            this.Text = "Lista Genérica";
            this.Load += new System.EventHandler(this.frmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lstvEstudiante;
        private System.Windows.Forms.DataGridView gridEstudiantes;
        private System.Windows.Forms.Button btnFiltrarmat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMayoredad;
        private System.Windows.Forms.TextBox txtMenoredad;
        private System.Windows.Forms.Button btnMostrar;
    }
}

