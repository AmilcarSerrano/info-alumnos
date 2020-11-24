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
    public partial class MenúAlumno : Form
    {
        public MenúAlumno()
        {
            InitializeComponent();
        }

        private void btnMosDat_Click(object sender, EventArgs e)
        {
            //int ID=0;
            //ID = int.Parse(txtID.Text);
            //MySqlDataReader reader = null;
            //string Sql = "SELECT Nombre, Apellido_Pat, Apellido_Mat, Edad, Direccion, Fecha_nacimiento, Telefono, Genero, Cuatrimestre FROM Alumnos WHERE matricula LIKE '" + ID + "' LIMIT 1";
            //MySqlConnection connect = Conexión.ObtenerConexión();
            //connect.Open();

            //try
            //{
            //    MySqlCommand command = new MySqlCommand(Sql, connect);
            //    reader = command.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
                        
            //            txtNombre.Text = reader.GetString(0);
            //            txtApellidoPat.Text = reader.GetString(1);
            //            txtApellidoMat.Text = reader.GetString(2);
            //            txtEdad.Text = reader.GetString(3);
            //            txtDirecccion.Text = reader.GetString(4);
            //            txtFNacimiento.Text = reader.GetString(5);
            //            txtTelefono.Text = reader.GetString(6);
            //            txtGenero.Text = reader.GetString(7);
            //            txtCuatrimestre.Text = reader.GetString(8);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("no se encontró nada");
            //    }
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show("Error al buscar: " + ex);
            //}
            //finally
            //{
            //    connect.Close();
            //}
        }

        private void rdbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectTab(0);
            int ID = 0;
            ID = int.Parse(txtID.Text);
            MySqlDataReader reader = null;
            string Sql = "SELECT Nombre, Apellido_Pat, Apellido_Mat, Edad, Direccion, Fecha_nacimiento, Telefono, Genero, Cuatrimestre FROM Alumnos WHERE matricula LIKE '" + ID + "' LIMIT 1";
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

                        txtNombre.Text = reader.GetString(0);
                        txtApellidoPat.Text = reader.GetString(1);
                        txtApellidoMat.Text = reader.GetString(2);
                        txtEdad.Text = reader.GetString(3);
                        txtDirecccion.Text = reader.GetString(4);
                        txtFNacimiento.Text = reader.GetString(5);
                        txtTelefono.Text = reader.GetString(6);
                        txtGenero.Text = reader.GetString(7);
                        txtCuatrimestre.Text = reader.GetString(8);
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

        private void rdbCalif_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectTab(1);
            ////
            int ID = 0;
            ID = int.Parse(txtID.Text);
            MySqlDataReader reader = null;
            

            string Sql = "SELECT id_materia, Calificacion FROM Calificaciones WHERE matricula LIKE '" + ID + "' ";
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

                        tbxMat1.Text = reader.GetString(0);
                        tbxCal1.Text = reader.GetString(1);
                        tbxMat2.Text = reader.GetString(0); //desde esta parte los datos comienzan a repetirse
                        tbxCal2.Text = reader.GetString(1);

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

        private void rdbPagos_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectTab(2);
        }

        private void rdbMaterias_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectTab(3);
        }
    }
}
