using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            IngresoAdmon InAdmn = new IngresoAdmon();
            IngresoAlumno InAlum = new IngresoAlumno();


            if (rdbAdmin.Checked)
            {
                this.Hide();
                InAdmn.ShowDialog();
                this.Show();


            }
            else if (rdbAlumno.Checked)
            {
                this.Hide();
                InAlum.ShowDialog();
               

            }
        }
    }
}
