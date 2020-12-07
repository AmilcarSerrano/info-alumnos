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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarAlumno actualizarAlumno = new ActualizarAlumno();
            this.Hide();
            actualizarAlumno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarMateria actualizarMateria = new ActualizarMateria();
            this.Hide();
            actualizarMateria.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarCalificacion actualizarCalificacion = new ActualizarCalificacion();
            this.Hide();
            actualizarCalificacion.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarPago actualizarPago = new ActualizarPago();
            this.Hide();
            actualizarPago.ShowDialog();
        }
    }
}
