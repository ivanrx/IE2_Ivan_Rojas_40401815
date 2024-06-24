namespace IE2_Ivan_Rojas
{
    partial class FormPreinscripcion
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
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstPreinscriptos = new System.Windows.Forms.ListBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCursos
            // 
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(114, 58);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(121, 21);
            this.cmbCursos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(303, 59);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(466, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstPreinscriptos
            // 
            this.lstPreinscriptos.FormattingEnabled = true;
            this.lstPreinscriptos.Location = new System.Drawing.Point(77, 159);
            this.lstPreinscriptos.Name = "lstPreinscriptos";
            this.lstPreinscriptos.Size = new System.Drawing.Size(326, 121);
            this.lstPreinscriptos.TabIndex = 5;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(77, 296);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // FormPreinscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lstPreinscriptos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCursos);
            this.Name = "FormPreinscripcion";
            this.Text = "FormPreinscripcion";
            this.Load += new System.EventHandler(this.FormPreinscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstPreinscriptos;
        private System.Windows.Forms.Button btnGrabar;
    }
}