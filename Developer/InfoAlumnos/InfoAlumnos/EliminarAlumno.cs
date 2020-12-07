using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InfoAlumnos
{
    public partial class EliminarAlumno : Form
    {
        public EliminarAlumno()
        {
            InitializeComponent();
        }

        private void btnEliminarAl_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
      

            string Sql = "DELETE  FROM Alumnos WHERE matricula='" + ID + "' ";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro de Alumno Eliminado Correctamente");
                txtID.Clear();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Actualizar los datos: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
