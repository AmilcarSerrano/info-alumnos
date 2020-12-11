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
    public partial class AdmnSelect : Form
    {
        public AdmnSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Registro
        {
            Registrar registrar = new Registrar();
            
            registrar.ShowDialog();
        }

        private void ActualizarR_Click(object sender, EventArgs e) //ActualizarR
        {
            Actualizar actualizar = new Actualizar();
            
            actualizar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)  //Eliminar
        {
            Eliminar eliminar = new Eliminar();
           
            eliminar.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BuscarAlumno buscarAlumno = new BuscarAlumno();
           
            buscarAlumno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
