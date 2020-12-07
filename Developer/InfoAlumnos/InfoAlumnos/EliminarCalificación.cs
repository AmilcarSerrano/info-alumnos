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
    public partial class EliminarCalificación : Form
    {
        public EliminarCalificación()
        {
            InitializeComponent();
        }

        private void btnEliminarCal_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            int IDM = int.Parse(txtIDM.Text);

            string Sql = "DELETE  FROM Calificaciones WHERE matricula ='" + ID + "' AND id_materia = '" + IDM + "' ";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro de Calificación Eliminado Correctamente");
                txtID.Clear();
                txtIDM.Clear();

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
