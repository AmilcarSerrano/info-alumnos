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
    public partial class RegistroPago : Form
    {
        public RegistroPago()
        {
            InitializeComponent();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtMatricula.Text);
            string Mes = txtMes.Text;
            int Cantidad =int.Parse(txtCantidad.Text);

            string Sql = "INSERT INTO Pagos (matricula, Mes, Cantidad)" +
               "VALUES ('" + ID + "', '" + Mes + "', '" + Cantidad + "')";

            MySqlConnection connect = Conexión.ObtenerConexión();
            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado correctamente");
                txtMatricula.Clear();
                txtMes.Clear();
                txtCantidad.Clear();

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
