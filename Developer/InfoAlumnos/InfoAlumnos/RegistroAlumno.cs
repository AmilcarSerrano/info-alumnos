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
    public partial class RegistroAlumno : Form
    {
        public RegistroAlumno()
        {
            InitializeComponent();
        }

        private void btnRegistrarAl_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ApellidoPat = txtApellidoPat.Text;
            string ApellidoMat = txtApellidoMat.Text;
            int Edad = int.Parse(txtEdad.Text);
            string FNacimiento = txtFNacimiento.Text;
            int Telefono = int.Parse(txtTelefono.Text);
            char Genero = char.Parse(txtGenero.Text);
            string Cuatrimestre = txtCuatrimestre.Text;
            string Direccion = txtDirecccion.Text;

            string Sql = "INSERT INTO Alumnos (Nombre, Apellido_Pat, Apellido_Mat, Edad, Direccion, Fecha_Nacimiento, Telefono, Genero, Cuatrimestre)" +
                "VALUES('" + nombre + "','" + ApellidoPat
                + "','" + ApellidoMat + "', '" + Edad + "','" + Direccion + "','" + FNacimiento + "', '" + Telefono + "', '" + Genero + "', '" + Cuatrimestre + "')";

            MySqlConnection connect = Conexión.ObtenerConexión();
            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");
                txtApellidoPat.Clear();
                txtApellidoMat.Clear();
                txtCuatrimestre.Clear();
                txtDirecccion.Clear();
                txtEdad.Clear();
                txtFNacimiento.Clear();
                txtFNacimiento.Clear();
                txtGenero.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
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

        private void RegistroAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
