using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace InfoAlumnos
{
    class Conexión
    {
        public static MySqlConnection ObtenerConexión()
        {
            MySqlConnection connect;
            string server = "127.0.0.1";
            string database = "escuela";
            string user = "root";
            string pass = "--";
            try
            {
                connect = new MySqlConnection("server = " + server +
                "; database = " + database +
                "; Uid = " + user +
                "; pwd = " + pass);
                return connect;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexión" + e.Message);
                return connect = new MySqlConnection();

            }

        }
    }
}
