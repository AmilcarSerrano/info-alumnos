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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarAlumno eliminarAlumno = new EliminarAlumno();
            this.Hide();
            eliminarAlumno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarMateria eliminarMateria = new EliminarMateria();
            this.Hide();
            eliminarMateria.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarPago eliminarPago = new EliminarPago();
            this.Hide();
            eliminarPago.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarCalificación eliminarCalificación = new EliminarCalificación();
            this.Hide();
            eliminarCalificación.Show();
        }
    }
}
