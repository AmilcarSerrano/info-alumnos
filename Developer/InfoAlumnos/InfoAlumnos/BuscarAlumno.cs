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
    public partial class BuscarAlumno : Form
    {
        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            
            string Nombres = txtNombreB.Text;
            string ApellidoPB = txtApellidoPB.Text;
            string ApellidoMB = txtApellidoMB.Text;
            MySqlDataReader reader = null;
            string Sql = "SELECT matricula, Nombre, Apellido_Pat, Apellido_Mat, Edad, Direccion, Fecha_nacimiento, Telefono, Genero, Cuatrimestre " +
                "FROM Alumnos WHERE Nombre LIKE '" + Nombres + "' " +
                "AND Apellido_Pat LIKE '" + ApellidoPB + "' AND Apellido_Mat LIKE '" + ApellidoMB + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();
            connect.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(Sql, connect);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtIDAlumno.Text = reader.GetString(0);
                        txtNombre.Text = reader.GetString(1);
                        txtApellidoPat.Text = reader.GetString(2);
                        txtApellidoMat.Text = reader.GetString(3);
                        txtEdad.Text = reader.GetString(4);
                        txtDirecccion.Text = reader.GetString(5);
                        txtFNacimiento.Text = reader.GetString(6);
                        txtTelefono.Text = reader.GetString(7);
                        txtGenero.Text = reader.GetString(8);
                        txtCuatrimestre.Text = reader.GetString(9);
                        txtNombreB.Clear();
                        txtApellidoPB.Clear();
                        txtApellidoMB.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("no se encontró nada");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar: " + ex);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
