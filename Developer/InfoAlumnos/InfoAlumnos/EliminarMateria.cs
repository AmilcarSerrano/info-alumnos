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
    public partial class EliminarMateria : Form
    {
        public EliminarMateria()
        {
            InitializeComponent();
        }

        private void btnEliminarAl_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);


            string Sql = "DELETE  FROM Materia WHERE id_materia='" + ID + "' ";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro de Materia Eliminado Correctamente");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EliminarMateria_Load(object sender, EventArgs e)
        {

        }
    }
}
