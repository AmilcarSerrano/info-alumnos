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
    public partial class ActualizarAlumno : Form
    {
        public ActualizarAlumno()
        {
            InitializeComponent();
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(1);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                int ID = int.Parse(txtID.Text);
                string Variable = txtNNombre.Text;

                string Sql = "UPDATE Alumnos SET Nombre = '" + Variable + "' WHERE matricula='" + ID + "'";
                MySqlConnection connect = Conexión.ObtenerConexión();

                connect.Open();

                try
                {
                    MySqlCommand comando = new MySqlCommand(Sql, connect);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Nombre actualizado correctamente");
                    txtID.Clear();
                    txtNNombre.Clear();

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

        private void rdbApellidoP_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDAP.Text);
            string Variable = txtApellidoP.Text;

            string Sql = "UPDATE Alumnos SET Apellido_Pat = '" + Variable + "' WHERE matricula='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Apellido Paterno actualizado correctamente");
                txtIDAP.Clear();
                txtApellidoP.Clear();

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

        private void rdbApellidoM_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(3);
        }

        private void btnActAM_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDAM.Text);
            string Variable = txtApellidoM.Text;

            string Sql = "UPDATE Alumnos SET Apellido_Mat = '" + Variable + "' WHERE matricula='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Apellido Materno actualizado correctamente");
                txtIDAM.Clear();
                txtApellidoM.Clear();

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

        private void rdbEdad_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDEDAD.Text);
            int Variable = int.Parse(txtEdad.Text);

            string Sql = "UPDATE Alumnos SET Edad = '" + Variable + "' WHERE matricula='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Edad actualizada correctamente");
                txtIDEDAD.Clear();
                txtEdad.Clear();

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

        private void rdbDireccion_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(5);
        }

        private void btnActDireccion_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDD.Text);
            string Variable = txtDireccion.Text;

            string Sql = "UPDATE Alumnos SET Direccion = '" + Variable + "' WHERE matricula='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dirección actualizada correctamente");
                txtIDD.Clear();
                txtDireccion.Clear();

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

        private void rdbFechaNac_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(6);
        }

        private void btnActFechaNacim_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDFN.Text);
            string Variable = txtFechaNacim.Text;

            string Sql = "UPDATE Alumnos SET Fecha_Nacimiento = '" + Variable + "' WHERE matricula='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Fecha de Nacimiento actualizada correctamente");
                txtIDFN.Clear();
                txtFechaNacim.Clear();

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

        private void rdbTelefono_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(7);
        }

        private void btnActTelefono_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDTel.Text);
            string Variable = txtTelefono.Text;

            string Sql = "UPDATE Alumnos SET Telefono = '" + Variable + "' WHERE matricula='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Telefono actualizado correctamente");
                txtIDTel.Clear();
                txtTelefono.Clear();

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

        private void rdbGenero_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(8);
        }

        private void btnActGenero_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDG.Text);
            string Variable = txtGenero.Text;

            string Sql = "UPDATE Alumnos SET Genero = '" + Variable + "' WHERE matricula='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Género actualizado correctamente");
                txtIDG.Clear();
                txtGenero.Clear();

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

        private void rdbCuatrimestre_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(9);
        }

        private void btnActCuatrimestre_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDC.Text);
            string Variable = txtCuatrimestre.Text;

            string Sql = "UPDATE Alumnos SET Cuatrimestre = '" + Variable + "' WHERE matricula='" + ID + "'";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cuatrimestre actualizado correctamente");
                txtIDC.Clear();
                txtCuatrimestre.Clear();

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

        private void rdbTodo_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipalA.SelectTab(10);
        }

        private void btnActTodo_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDTotal.Text);
            string Nombre = txtNombreT.Text;
            string ApellidoP = txtApellidoPT.Text;
            string ApellidoM = txtApellidoMT.Text;
            int Edad = int.Parse(txtEdadT.Text);
            string Direccion = txtDireccionT.Text;
            string FechaNacim = txtFechaNacimT.Text;
            int Telefono = int.Parse(txtTelefonoT.Text);
            string Genero = txtGeneroT.Text;
            string Cuatrimestre = txtCuatrimestreT.Text;

            string Sql = "UPDATE Alumnos SET Nombre = '" + Nombre + "', " +
                                         "Apellido_Pat = '" + ApellidoP + "'," +
                                         "Apellido_Mat = '" + ApellidoM + "', " +
                                         "Edad = '" + Edad + "'," +
                                         "Direccion = '" + Direccion + "'," +
                                         "Fecha_Nacimiento = '" + FechaNacim + "'," +
                                         "Telefono = '" + Telefono + "'," +
                                         "Genero = '" + Genero + "'," +
                                         "Cuatrimestre = '" + Cuatrimestre + "'" +
                                         "WHERE matricula='" + ID + "'";

            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
                txtIDTotal.Clear();
                txtNombreT.Clear();
                txtApellidoPT.Clear();
                txtApellidoMT.Clear();
                txtEdadT.Clear();
                txtDireccionT.Clear();
                txtFechaNacimT.Clear();
                txtTelefonoT.Clear();
                txtGeneroT.Clear();
                txtCuatrimestreT.Clear();

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
