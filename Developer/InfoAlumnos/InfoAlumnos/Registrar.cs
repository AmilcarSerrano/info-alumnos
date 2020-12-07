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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroAlumno registroAlumno = new RegistroAlumno();
            this.Hide();
            registroAlumno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroMateria registroMateria = new RegistroMateria();
            this.Hide();
            registroMateria.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroPago registroPago = new RegistroPago();
            this.Hide();
            registroPago.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistroCalificaciones registroCalificaciones = new RegistroCalificaciones();
            this.Hide();
            registroCalificaciones.Show();
        }
    }
}
