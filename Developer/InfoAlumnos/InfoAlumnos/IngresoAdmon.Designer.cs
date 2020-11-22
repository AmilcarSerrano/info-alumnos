namespace InfoAlumnos
{
    partial class IngresoAdmon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxContraseña = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresarAdmn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "N°Admon";
            // 
            // tbxContraseña
            // 
            this.tbxContraseña.Location = new System.Drawing.Point(103, 89);
            this.tbxContraseña.Name = "tbxContraseña";
            this.tbxContraseña.Size = new System.Drawing.Size(107, 20);
            this.tbxContraseña.TabIndex = 5;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(103, 39);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(107, 20);
            this.tbxUsuario.TabIndex = 4;
            // 
            // btnIngresarAdmn
            // 
            this.btnIngresarAdmn.Location = new System.Drawing.Point(94, 126);
            this.btnIngresarAdmn.Name = "btnIngresarAdmn";
            this.btnIngresarAdmn.Size = new System.Drawing.Size(89, 24);
            this.btnIngresarAdmn.TabIndex = 8;
            this.btnIngresarAdmn.Text = "Ingresar";
            this.btnIngresarAdmn.UseVisualStyleBackColor = true;
            this.btnIngresarAdmn.Click += new System.EventHandler(this.btnIngresarAdmn_Click);
            // 
            // IngresoAdmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 162);
            this.Controls.Add(this.btnIngresarAdmn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxContraseña);
            this.Controls.Add(this.tbxUsuario);
            this.Name = "IngresoAdmon";
            this.Text = "IngresoAdmon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxContraseña;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Button btnIngresarAdmn;
    }
}