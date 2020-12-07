namespace InfoAlumnos
{
    partial class ActualizarMateria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNMateria = new System.Windows.Forms.RadioButton();
            this.rdbNProfesor = new System.Windows.Forms.RadioButton();
            this.rdbTodo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActNomMateria = new System.Windows.Forms.Button();
            this.txtIDM = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.txtIDMP = new System.Windows.Forms.TextBox();
            this.btnActNomProf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfesorT = new System.Windows.Forms.TextBox();
            this.txtIDMT = new System.Windows.Forms.TextBox();
            this.btnActTodo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMateriaT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.rdbTodo);
            this.panel1.Controls.Add(this.rdbNProfesor);
            this.panel1.Controls.Add(this.rdbNMateria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 248);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(90, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(196, 248);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(188, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMateria);
            this.tabPage2.Controls.Add(this.txtIDM);
            this.tabPage2.Controls.Add(this.btnActNomMateria);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(188, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué desea\r\nactualizar de\r\nla materia?";
            // 
            // rdbNMateria
            // 
            this.rdbNMateria.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbNMateria.AutoSize = true;
            this.rdbNMateria.BackColor = System.Drawing.Color.Purple;
            this.rdbNMateria.FlatAppearance.BorderSize = 0;
            this.rdbNMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbNMateria.Location = new System.Drawing.Point(7, 123);
            this.rdbNMateria.Name = "rdbNMateria";
            this.rdbNMateria.Size = new System.Drawing.Size(80, 23);
            this.rdbNMateria.TabIndex = 1;
            this.rdbNMateria.TabStop = true;
            this.rdbNMateria.Text = "Nom. Materia";
            this.rdbNMateria.UseVisualStyleBackColor = false;
            this.rdbNMateria.CheckedChanged += new System.EventHandler(this.rdbNMateria_CheckedChanged);
            // 
            // rdbNProfesor
            // 
            this.rdbNProfesor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbNProfesor.AutoSize = true;
            this.rdbNProfesor.BackColor = System.Drawing.Color.Purple;
            this.rdbNProfesor.FlatAppearance.BorderSize = 0;
            this.rdbNProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbNProfesor.Location = new System.Drawing.Point(7, 163);
            this.rdbNProfesor.Name = "rdbNProfesor";
            this.rdbNProfesor.Size = new System.Drawing.Size(84, 23);
            this.rdbNProfesor.TabIndex = 2;
            this.rdbNProfesor.TabStop = true;
            this.rdbNProfesor.Text = "Nom. Profesor";
            this.rdbNProfesor.UseVisualStyleBackColor = false;
            this.rdbNProfesor.CheckedChanged += new System.EventHandler(this.rdbNProfesor_CheckedChanged);
            // 
            // rdbTodo
            // 
            this.rdbTodo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbTodo.AutoSize = true;
            this.rdbTodo.BackColor = System.Drawing.Color.Purple;
            this.rdbTodo.FlatAppearance.BorderSize = 0;
            this.rdbTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbTodo.Location = new System.Drawing.Point(15, 201);
            this.rdbTodo.Name = "rdbTodo";
            this.rdbTodo.Size = new System.Drawing.Size(48, 23);
            this.rdbTodo.TabIndex = 3;
            this.rdbTodo.TabStop = true;
            this.rdbTodo.Text = "TODO";
            this.rdbTodo.UseVisualStyleBackColor = false;
            this.rdbTodo.CheckedChanged += new System.EventHandler(this.rdbTodo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elija una Opción...";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtProfesor);
            this.tabPage3.Controls.Add(this.txtIDMP);
            this.tabPage3.Controls.Add(this.btnActNomProf);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(188, 222);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtMateriaT);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtProfesorT);
            this.tabPage4.Controls.Add(this.txtIDMT);
            this.tabPage4.Controls.Add(this.btnActTodo);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(188, 222);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id de la materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Materia Actualizada";
            // 
            // btnActNomMateria
            // 
            this.btnActNomMateria.Location = new System.Drawing.Point(48, 141);
            this.btnActNomMateria.Name = "btnActNomMateria";
            this.btnActNomMateria.Size = new System.Drawing.Size(97, 24);
            this.btnActNomMateria.TabIndex = 6;
            this.btnActNomMateria.Text = "Actualizar";
            this.btnActNomMateria.UseVisualStyleBackColor = true;
            this.btnActNomMateria.Click += new System.EventHandler(this.btnActNomMateria_Click);
            // 
            // txtIDM
            // 
            this.txtIDM.Location = new System.Drawing.Point(48, 71);
            this.txtIDM.Name = "txtIDM";
            this.txtIDM.Size = new System.Drawing.Size(97, 20);
            this.txtIDM.TabIndex = 7;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(48, 110);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(97, 20);
            this.txtMateria.TabIndex = 8;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(46, 109);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(97, 20);
            this.txtProfesor.TabIndex = 13;
            // 
            // txtIDMP
            // 
            this.txtIDMP.Location = new System.Drawing.Point(46, 70);
            this.txtIDMP.Name = "txtIDMP";
            this.txtIDMP.Size = new System.Drawing.Size(97, 20);
            this.txtIDMP.TabIndex = 12;
            // 
            // btnActNomProf
            // 
            this.btnActNomProf.Location = new System.Drawing.Point(46, 140);
            this.btnActNomProf.Name = "btnActNomProf";
            this.btnActNomProf.Size = new System.Drawing.Size(97, 24);
            this.btnActNomProf.TabIndex = 11;
            this.btnActNomProf.Text = "Actualizar";
            this.btnActNomProf.UseVisualStyleBackColor = true;
            this.btnActNomProf.Click += new System.EventHandler(this.btnActNomProf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nuevo Profesor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Id de la materia";
            // 
            // txtProfesorT
            // 
            this.txtProfesorT.Location = new System.Drawing.Point(46, 143);
            this.txtProfesorT.Name = "txtProfesorT";
            this.txtProfesorT.Size = new System.Drawing.Size(97, 20);
            this.txtProfesorT.TabIndex = 18;
            // 
            // txtIDMT
            // 
            this.txtIDMT.Location = new System.Drawing.Point(46, 55);
            this.txtIDMT.Name = "txtIDMT";
            this.txtIDMT.Size = new System.Drawing.Size(97, 20);
            this.txtIDMT.TabIndex = 17;
            // 
            // btnActTodo
            // 
            this.btnActTodo.Location = new System.Drawing.Point(46, 178);
            this.btnActTodo.Name = "btnActTodo";
            this.btnActTodo.Size = new System.Drawing.Size(97, 24);
            this.btnActTodo.TabIndex = 16;
            this.btnActTodo.Text = "Actualizar";
            this.btnActTodo.UseVisualStyleBackColor = true;
            this.btnActTodo.Click += new System.EventHandler(this.btnActTodo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nuevo Profesor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Id de la materia";
            // 
            // txtMateriaT
            // 
            this.txtMateriaT.Location = new System.Drawing.Point(46, 105);
            this.txtMateriaT.Name = "txtMateriaT";
            this.txtMateriaT.Size = new System.Drawing.Size(97, 20);
            this.txtMateriaT.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Materia Actualizada";
            // 
            // ActualizarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 248);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ActualizarMateria";
            this.Text = "ActualizarMateria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbTodo;
        private System.Windows.Forms.RadioButton rdbNProfesor;
        private System.Windows.Forms.RadioButton rdbNMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtIDM;
        private System.Windows.Forms.Button btnActNomMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtIDMP;
        private System.Windows.Forms.Button btnActNomProf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMateriaT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProfesorT;
        private System.Windows.Forms.TextBox txtIDMT;
        private System.Windows.Forms.Button btnActTodo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}