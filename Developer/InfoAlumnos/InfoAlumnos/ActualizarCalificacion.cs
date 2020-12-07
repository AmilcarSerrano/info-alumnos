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
    public partial class ActualizarCalificacion : Form
    {
        public ActualizarCalificacion()
        {
            InitializeComponent();
        }

        private void ActualizarCalificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizarCalif_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDMatricula.Text);
            int IDM = int.Parse(txtIDMateria.Text);
            int Variable = int.Parse(txtCalificacion.Text);

            string Sql = "UPDATE Calificaciones SET Calificacion = '" + Variable + "' WHERE matricula='" + ID + "' AND id_materia='" + IDM + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Calificación actualizad correctamente");
                txtIDMatricula.Clear();
                txtIDMateria.Clear();
                txtCalificacion.Clear();

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
