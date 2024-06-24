namespace IE2_Ivan_Rojas
{
    partial class FormArmarCurso
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
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(154, 53);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbCurso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Inicio";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(387, 53);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.txtFechaInicio.TabIndex = 3;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(573, 54);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.txtFechaFin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Fin";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(117, 106);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "Asignar Alumnos";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(598, 106);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // FormArmarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCurso);
            this.Name = "FormArmarCurso";
            this.Text = "FormArmarCurso";
            this.Load += new System.EventHandler(this.FormArmarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnGrabar;
    }
}