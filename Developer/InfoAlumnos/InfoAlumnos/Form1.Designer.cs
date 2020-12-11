namespace InfoAlumnos
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
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbAlumno = new System.Windows.Forms.RadioButton();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(55, 59);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(88, 17);
            this.rdbAdmin.TabIndex = 0;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbAlumno
            // 
            this.rdbAlumno.AutoSize = true;
            this.rdbAlumno.Location = new System.Drawing.Point(55, 94);
            this.rdbAlumno.Name = "rdbAlumno";
            this.rdbAlumno.Size = new System.Drawing.Size(60, 17);
            this.rdbAlumno.TabIndex = 1;
            this.rdbAlumno.TabStop = true;
            this.rdbAlumno.Text = "Alumno";
            this.rdbAlumno.UseVisualStyleBackColor = true;
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnContinuar.Location = new System.Drawing.Point(55, 117);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(70, 23);
            this.BtnContinuar.TabIndex = 2;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(245, 174);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.rdbAlumno);
            this.Controls.Add(this.rdbAdmin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbAlumno;
        private System.Windows.Forms.Button BtnContinuar;
    }
}

