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
    public partial class RegistroAlum : Form
    {
        public RegistroAlum()
        {
            InitializeComponent();
        }

        private void btnRegAlum_Click(object sender, EventArgs e)
        {
            int Contraseña = int.Parse(tbxContraseña.Text);
            int Confirmacion = int.Parse(tbxConfirmacion.Text);

            if (Contraseña==Confirmacion)
            {
                string matricula = tbxUsuario.Text;
                int Contraseña1 = int.Parse(tbxContraseña.Text);
                string Sql = "UPDATE Alumnos SET Contrasena = '" + Contraseña1 + "' WHERE matricula='" + matricula + "'";
                MySqlConnection connect = Conexión.ObtenerConexión();

                connect.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(Sql, connect);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Contraseña guardada");

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
            else
            {
                MessageBox.Show("Las contraseñas no Coinciden");
            }
            this.Hide();
            IngresoAlumno ingreso = new IngresoAlumno();
            ingreso.Show();
        }
    }
}
