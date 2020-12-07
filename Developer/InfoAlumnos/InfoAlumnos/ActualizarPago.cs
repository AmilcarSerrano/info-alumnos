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
    public partial class ActualizarPago : Form
    {
        public ActualizarPago()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void btnActMotivo_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDPago.Text);
            string Variable =txtMotivo.Text;

            string Sql = "UPDATE Pagos SET Mes = '" + Variable + "' WHERE id_Adeudos='" + ID + "' ";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Motivo actualizado correctamente");
                txtMotivo.Clear();
                txtIDPago.Clear();
                

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

        private void btnActualizarCantidad_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDPago2.Text);
            int Variable = int.Parse(txtCantidadAct.Text);

            string Sql = "UPDATE Pagos SET Cantidad = '" + Variable + "' WHERE id_Adeudos='" + ID + "' ";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cantidad actualizada correctamente");
                txtCantidadAct.Clear();
                txtIDPago2.Clear();
                txtDebia.Clear();


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

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDPagoT.Text);
            string Variable = txtMotivoT.Text;
            int Variable2 = int.Parse(txtCantidadActT.Text);
            string Sql = "UPDATE Pagos SET Mes = '" + Variable + "', Cantidad = '" + Variable2 + "' WHERE id_Adeudos='" + ID + "' ";
            MySqlConnection connect = Conexión.ObtenerConexión();

            connect.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(Sql, connect);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente");
                txtMotivoT.Clear();
                txtIDPagoT.Clear();
                txtCantidadActT.Clear();


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

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDPago2.Text);
            MySqlDataReader reader = null;
            string Sql = "SELECT Cantidad FROM Pagos WHERE id_Adeudos LIKE '" + ID + "' LIMIT 1";
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

                        txtDebia.Text = reader.GetString(0);

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

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDPagoT.Text);
            MySqlDataReader reader = null;
            string Sql = "SELECT Cantidad FROM Pagos WHERE id_Adeudos LIKE '" + ID + "' LIMIT 1";
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

                        textBox1.Text = reader.GetString(0);

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

        private void rdbBuscarPago_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            //// 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ID = 0;
            ID = int.Parse(txtID.Text);

            MySqlDataReader reader = null;
            string Sql = "SELECT Cantidad FROM Pagos WHERE matricula LIKE '" + ID + "'and Mes = " + " \"septiembre\"" + "";
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


                        tbxPag1.Text = reader.GetString(0);
                        //desde esta parte los datos comienzan a repetirse


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


            MySqlDataReader reader2 = null;
            string Sql2 = "SELECT Cantidad FROM Pagos WHERE matricula LIKE '" + ID + "'and Mes = " + " \"octubre\"" + "";
            MySqlConnection connect2 = Conexión.ObtenerConexión();
            connect2.Open();

            try
            {
                MySqlCommand command2 = new MySqlCommand(Sql2, connect2);
                reader2 = command2.ExecuteReader();

                if (reader2.HasRows)

                {
                    while (reader2.Read())
                    {


                        tbxPag2.Text = reader2.GetString(0);
                        //desde esta parte los datos comienzan a repetirse


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

                connect2.Close();
            }

            MySqlDataReader reader3 = null;
            string Sql3 = "SELECT Cantidad FROM Pagos WHERE matricula LIKE '" + ID + "'and Mes = " + " \"noviembre\"" + "";
            MySqlConnection connect3 = Conexión.ObtenerConexión();
            connect3.Open();

            try
            {
                MySqlCommand command3 = new MySqlCommand(Sql3, connect3);
                reader3 = command3.ExecuteReader();

                if (reader3.HasRows)

                {
                    while (reader3.Read())
                    {


                        tbxPag3.Text = reader3.GetString(0);
                        //desde esta parte los datos comienzan a repetirse


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

                connect3.Close();
            }


            MySqlDataReader reader4 = null;
            string Sql4 = "SELECT Cantidad FROM Pagos WHERE matricula LIKE '" + ID + "'and Mes = " + " \"diciembre\"" + "";
            MySqlConnection connect4 = Conexión.ObtenerConexión();
            connect4.Open();

            try
            {
                MySqlCommand command4 = new MySqlCommand(Sql4, connect4);
                reader4 = command4.ExecuteReader();

                if (reader4.HasRows)

                {
                    while (reader4.Read())
                    {


                        tbxPag4.Text = reader4.GetString(0);
                        //desde esta parte los datos comienzan a repetirse


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

                connect4.Close();
            }
        }
    }
}
