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
    public partial class RegistroCalificaciones : Form
    {
        public RegistroCalificaciones()
        {
            InitializeComponent();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtMatricula.Text);
            int IDMateria = int.Parse(txtIdMateria.Text);
            int Calificacion = int.Parse(txtCalificacion.Text);

            string Sql = "INSERT INTO Calificaciones (id_materia, matricula, Calificacion)" +
              "VALUES ('" + IDMateria + "', '" + ID + "', '" + Calificacion + "')";

            MySqlConnection connect = Conexión.ObtenerConexión();
            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");
                
                txtIdMateria.Clear();
                txtCalificacion.Clear();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar los datos: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
