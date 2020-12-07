namespace InfoAlumnos
{
    partial class ActualizarCalificacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarCalif = new System.Windows.Forms.Button();
            this.txtIDMatricula = new System.Windows.Forms.TextBox();
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa los siguientes datos: ";
            // 
            // btnActualizarCalif
            // 
            this.btnActualizarCalif.Location = new System.Drawing.Point(41, 183);
            this.btnActualizarCalif.Name = "btnActualizarCalif";
            this.btnActualizarCalif.Size = new System.Drawing.Size(86, 26);
            this.btnActualizarCalif.TabIndex = 1;
            this.btnActualizarCalif.Text = "Actualizar";
            this.btnActualizarCalif.UseVisualStyleBackColor = true;
            this.btnActualizarCalif.Click += new System.EventHandler(this.btnActualizarCalif_Click);
            // 
            // txtIDMatricula
            // 
            this.txtIDMatricula.Location = new System.Drawing.Point(41, 79);
            this.txtIDMatricula.Name = "txtIDMatricula";
            this.txtIDMatricula.Size = new System.Drawing.Size(86, 20);
            this.txtIDMatricula.TabIndex = 2;
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(41, 118);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.Size = new System.Drawing.Size(86, 20);
            this.txtIDMateria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID del estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID de la materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calificación Actualizada";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(41, 157);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(86, 20);
            this.txtCalificacion.TabIndex = 5;
            // 
            // ActualizarCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 221);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDMateria);
            this.Controls.Add(this.txtIDMatricula);
            this.Controls.Add(this.btnActualizarCalif);
            this.Controls.Add(this.panel1);
            this.Name = "ActualizarCalificacion";
            this.Text = "ActualizarCalificacion";
            this.Load += new System.EventHandler(this.ActualizarCalificacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarCalif;
        private System.Windows.Forms.TextBox txtIDMatricula;
        private System.Windows.Forms.TextBox txtIDMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalificacion;
    }
}