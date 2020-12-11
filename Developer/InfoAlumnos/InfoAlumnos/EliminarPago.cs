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
    public partial class EliminarPago : Form
    {
        public EliminarPago()
        {
            InitializeComponent();
        }

        private void btnEliminarPA_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);


            string Sql = "DELETE  FROM Pagos WHERE id_Adeudos='" + ID + "' ";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro de Pago Eliminado Correctamente");
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

        private void EliminarPago_Load(object sender, EventArgs e)
        {

        }
    }
}
