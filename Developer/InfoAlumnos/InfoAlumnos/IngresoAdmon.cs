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
    public partial class IngresoAdmon : Form
    {
        public IngresoAdmon()
        {
            InitializeComponent();
        }

        private void btnIngresarAdmn_Click(object sender, EventArgs e)
        {
            int admon = 44;
            string pass = "password";
            int user = int.Parse(tbxUsuario.Text);
            string contraseña = tbxContraseña.Text;

            if(user == admon && contraseña == pass)
            {
                MessageBox.Show("Sos la reata");
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña Incorrecta");

            }

        }
    }
}
