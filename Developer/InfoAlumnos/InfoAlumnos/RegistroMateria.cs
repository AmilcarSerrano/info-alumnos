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
    public partial class RegistroMateria : Form
    {
        public RegistroMateria()
        {
            InitializeComponent();
        }

        private void btnRegistrarMateria_Click(object sender, EventArgs e)
        {
            string NMateria = txtNMateriaR.Text;
            string NProfesor = txtNProfesorR.Text;

            string Sql = "INSERT INTO Materia (Nom_materia, Nom_profesor)" + 
                "VALUES ('" + NMateria + "', '" + NProfesor + "')";

            MySqlConnection connect = Conexión.ObtenerConexión();
            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");
                txtNMateriaR.Clear();
                txtNProfesorR.Clear();
               
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
    }
}
