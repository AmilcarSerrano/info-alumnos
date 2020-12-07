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
    public partial class ActualizarMateria : Form
    {
        public ActualizarMateria()
        {
            InitializeComponent();
        }

        private void rdbNMateria_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void rdbNProfesor_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void rdbTodo_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void btnActNomMateria_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDM.Text);
            string Variable = txtMateria.Text;

            string Sql = "UPDATE Materia SET Nom_Materia = '" + Variable + "' WHERE id_materia ='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Nombre de Materia actualizado correctamente");
                txtIDM.Clear();
                txtMateria.Clear();

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

        private void btnActNomProf_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDMP.Text);
            string Variable = txtProfesor.Text;

            string Sql = "UPDATE Materia SET Nom_Profesor = '" + Variable + "' WHERE id_materia ='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Nombre del Profesor actualizado correctamente");
                txtIDMP.Clear();
                txtProfesor.Clear();

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

        private void btnActTodo_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDMT.Text);
            string Variable2 = txtMateriaT.Text;
            string Variable = txtProfesorT.Text;

            string Sql = "UPDATE Materia SET Nom_Profesor = '" + Variable + "'," +
                                         " Nom_Materia = '" + Variable2 + "'WHERE id_materia ='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
                txtIDMT.Clear();
                txtProfesorT.Clear();
                txtMateriaT.Clear();

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
