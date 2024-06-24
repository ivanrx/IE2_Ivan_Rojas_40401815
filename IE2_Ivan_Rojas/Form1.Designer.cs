namespace IE2_Ivan_Rojas
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAltaEstudiantes = new System.Windows.Forms.Button();
            this.btnAltaCurso = new System.Windows.Forms.Button();
            this.btnPreinscribirAlumno = new System.Windows.Forms.Button();
            this.btnArmarCurso = new System.Windows.Forms.Button();
            this.btnConsultarCurso = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(112, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de inicio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de fin";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad de alumnos inscriptos";
            this.Column5.Name = "Column5";
            // 
            // btnAltaEstudiantes
            // 
            this.btnAltaEstudiantes.Location = new System.Drawing.Point(123, 381);
            this.btnAltaEstudiantes.Name = "btnAltaEstudiantes";
            this.btnAltaEstudiantes.Size = new System.Drawing.Size(81, 40);
            this.btnAltaEstudiantes.TabIndex = 1;
            this.btnAltaEstudiantes.Text = "Agregar Estudiantes";
            this.btnAltaEstudiantes.UseVisualStyleBackColor = true;
            this.btnAltaEstudiantes.Click += new System.EventHandler(this.btnAltaEstudiantes_Click);
            // 
            // btnAltaCurso
            // 
            this.btnAltaCurso.Location = new System.Drawing.Point(220, 381);
            this.btnAltaCurso.Name = "btnAltaCurso";
            this.btnAltaCurso.Size = new System.Drawing.Size(75, 39);
            this.btnAltaCurso.TabIndex = 2;
            this.btnAltaCurso.Text = "Agregar Curso";
            this.btnAltaCurso.UseVisualStyleBackColor = true;
            this.btnAltaCurso.Click += new System.EventHandler(this.btnAltaCurso_Click);
            // 
            // btnPreinscribirAlumno
            // 
            this.btnPreinscribirAlumno.Location = new System.Drawing.Point(310, 382);
            this.btnPreinscribirAlumno.Name = "btnPreinscribirAlumno";
            this.btnPreinscribirAlumno.Size = new System.Drawing.Size(75, 39);
            this.btnPreinscribirAlumno.TabIndex = 3;
            this.btnPreinscribirAlumno.Text = "Preinscribir Alumno";
            this.btnPreinscribirAlumno.UseVisualStyleBackColor = true;
            this.btnPreinscribirAlumno.Click += new System.EventHandler(this.btnPreinscribirAlumno_Click);
            // 
            // btnArmarCurso
            // 
            this.btnArmarCurso.Location = new System.Drawing.Point(406, 381);
            this.btnArmarCurso.Name = "btnArmarCurso";
            this.btnArmarCurso.Size = new System.Drawing.Size(75, 40);
            this.btnArmarCurso.TabIndex = 4;
            this.btnArmarCurso.Text = "Armar Curso";
            this.btnArmarCurso.UseVisualStyleBackColor = true;
            this.btnArmarCurso.Click += new System.EventHandler(this.btnArmarCurso_Click);
            // 
            // btnConsultarCurso
            // 
            this.btnConsultarCurso.Location = new System.Drawing.Point(510, 382);
            this.btnConsultarCurso.Name = "btnConsultarCurso";
            this.btnConsultarCurso.Size = new System.Drawing.Size(75, 38);
            this.btnConsultarCurso.TabIndex = 5;
            this.btnConsultarCurso.Text = "Consultar Curso";
            this.btnConsultarCurso.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(600, 381);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(75, 39);
            this.btnAsistencia.TabIndex = 6;
            this.btnAsistencia.Text = "Generar Lista";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnConsultarCurso);
            this.Controls.Add(this.btnArmarCurso);
            this.Controls.Add(this.btnPreinscribirAlumno);
            this.Controls.Add(this.btnAltaCurso);
            this.Controls.Add(this.btnAltaEstudiantes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnAltaEstudiantes;
        private System.Windows.Forms.Button btnAltaCurso;
        private System.Windows.Forms.Button btnPreinscribirAlumno;
        private System.Windows.Forms.Button btnArmarCurso;
        private System.Windows.Forms.Button btnConsultarCurso;
        private System.Windows.Forms.Button btnAsistencia;
    }
}

