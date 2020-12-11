namespace InfoAlumnos
{
    partial class RegistroAlum
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
            this.btnRegAlum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxConfirmacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegAlum
            // 
            this.btnRegAlum.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegAlum.Location = new System.Drawing.Point(128, 136);
            this.btnRegAlum.Name = "btnRegAlum";
            this.btnRegAlum.Size = new System.Drawing.Size(89, 24);
            this.btnRegAlum.TabIndex = 8;
            this.btnRegAlum.Text = "Registrar";
            this.btnRegAlum.UseVisualStyleBackColor = false;
            this.btnRegAlum.Click += new System.EventHandler(this.btnRegAlum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Matrícula";
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Location = new System.Drawing.Point(119, 87);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.PasswordChar = '*';
            this.tbxContraseña.Size = new System.Drawing.Size(107, 20);
            this.tbxContraseña.TabIndex = 6;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(119, 61);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(107, 20);
            this.tbxUsuario.TabIndex = 5;
            // 
            // tbxConfirmacion
            // 
            this.tbxConfirmacion.Location = new System.Drawing.Point(119, 110);
            this.tbxConfirmacion.Name = "tbxConfirmacion";
            this.tbxConfirmacion.PasswordChar = '*';
            this.tbxConfirmacion.Size = new System.Drawing.Size(107, 20);
            this.tbxConfirmacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // RegistroAlum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(238, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxConfirmacion);
            this.Controls.Add(this.btnRegAlum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxContraseña);
            this.Controls.Add(this.tbxUsuario);
            this.Name = "RegistroAlum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroAlum";
            this.Load += new System.EventHandler(this.RegistroAlum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegAlum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxContraseña;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxConfirmacion;
        private System.Windows.Forms.Label label3;
    }
}