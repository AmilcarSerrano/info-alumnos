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
            int ID = 0;
            ID = int.Parse(txtID.Text);
            MySqlDataReader reader = null;
            MySqlDataReader reade = null;
            MySqlDataReader read = null;
            MySqlDataReader rea = null;
            MySqlDataReader re = null;
            MySqlDataReader r = null;

            string Sql = "SELECT Calificacion FROM Calificaciones WHERE matricula LIKE '" + ID + "' AND id_materia LIKE '1' ";
            MySqlConnection connect = Conexión.ObtenerConexión();
            connect.Open();
            string xD = "SELECT Calificacion FROM Calificaciones WHERE matricula LIKE '" + ID + "' AND id_materia LIKE '2' ";
            MySqlConnection XD = Conexión.ObtenerConexión();
            XD.Open();
            string Ad = "SELECT Calificacion FROM Calificaciones WHERE matricula LIKE '" + ID + "' AND id_materia LIKE '3' ";
            MySqlConnection AD = Conexión.ObtenerConexión();
            AD.Open();
            string Av = "SELECT Calificacion FROM Calificaciones WHERE matricula LIKE '" + ID + "' AND id_materia LIKE '4' ";
            MySqlConnection AV = Conexión.ObtenerConexión();
            AV.Open();
            string Ac = "SELECT Calificacion FROM Calificaciones WHERE matricula LIKE '" + ID + "' AND id_materia LIKE '5' ";
            MySqlConnection AC = Conexión.ObtenerConexión();
            AC.Open();
            string Af = "SELECT Calificacion FROM Calificaciones WHERE matricula LIKE '" + ID + "' AND id_materia LIKE '6' ";
            MySqlConnection AF = Conexión.ObtenerConexión();
            AF.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(Sql, connect);
                reader = command.ExecuteReader();
               
                if (reader.HasRows)

                {
                    while (reader.Read())
                    {

                        
                        tbxCal1.Text = reader.GetString(0);
                        
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
           

            try
            {
                MySqlCommand comman = new MySqlCommand(xD, XD);
                reade = comman.ExecuteReader();

                if (reade.HasRows)

                {
                    while (reade.Read())
                    {


                       
                        //desde esta parte los datos comienzan a repetirse
                        tbxCal2.Text = reade.GetString(0);
                       
                       
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
                XD.Close();
                
            }


            try
            {
                MySqlCommand comma = new MySqlCommand(Ad, AD);
                read = comma.ExecuteReader();

                if (read.HasRows)

                {
                    while (read.Read())
                    {



                        //desde esta parte los datos comienzan a repetirse
                        tbxCal3.Text = read.GetString(0);

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
                AD.Close();

            }

            try
            {
                MySqlCommand comm = new MySqlCommand(Av, AV);
                rea = comm.ExecuteReader();

                if (rea.HasRows)

                {
                    while (rea.Read())
                    {



                        //desde esta parte los datos comienzan a repetirse
                        tbxCal4.Text = rea.GetString(0);

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
                AV.Close();

            }

            try
            {
                MySqlCommand com = new MySqlCommand(Ac, AC);
                re = com.ExecuteReader();

                if (re.HasRows)

                {
                    while (re.Read())
                    {



                        //desde esta parte los datos comienzan a repetirse
                        tbxCal5.Text = re.GetString(0);

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
                AC.Close();

            }

            try
            {
                MySqlCommand co = new MySqlCommand(Af, AF);
                r = co.ExecuteReader();

                if (r.HasRows)

                {
                    while (r.Read())
                    {



                        //desde esta parte los datos comienzan a repetirse
                        tbxCal6.Text = r.GetString(0);

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
                AF.Close();

            }



        }

        private void rdbPagos_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectTab(2);
            ///
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

        private void rdbMaterias_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectTab(3);
            ////
            int ID = 0;
            ID = int.Parse(txtID.Text);

            MySqlDataReader reader = null;
            string Sql = "select Nom_materia, Nom_profesor  from Materia where id_materia =1;";
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


                        tbxria1.Text = reader.GetString(0);
                        tbxpro1.Text = reader.GetString(1);


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
            string Sql2 = "select Nom_materia, Nom_profesor  from Materia where id_materia =2;";
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


                        tbxria2.Text = reader2.GetString(0);
                        tbxpro2.Text = reader2.GetString(1);


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
            string Sql3 = "select Nom_materia, Nom_profesor  from Materia where id_materia =3;";
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


                        tbxria3.Text = reader3.GetString(0);
                        tbxpro3.Text = reader3.GetString(1);


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
            string Sql4 = "select Nom_materia, Nom_profesor  from Materia where id_materia =4;";
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


                        tbxria4.Text = reader4.GetString(0);
                        tbxpro4.Text = reader4.GetString(1);


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



            MySqlDataReader reader5 = null;
            string Sql5 = "select Nom_materia, Nom_profesor  from Materia where id_materia =5;";
            MySqlConnection connect5 = Conexión.ObtenerConexión();
            connect5.Open();

            try
            {
                MySqlCommand command5 = new MySqlCommand(Sql5, connect5);
                reader5 = command5.ExecuteReader();

                if (reader5.HasRows)

                {
                    while (reader5.Read())
                    {


                        tbxria5.Text = reader5.GetString(0);
                        tbxpro5.Text = reader5.GetString(1);


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

                connect5.Close();
            }


            MySqlDataReader reader6 = null;
            string Sql6 = "select Nom_materia, Nom_profesor  from Materia where id_materia =6;";
            MySqlConnection connect6 = Conexión.ObtenerConexión();
            connect6.Open();

            try
            {
                MySqlCommand command6 = new MySqlCommand(Sql6, connect6);
                reader6 = command6.ExecuteReader();

                if (reader6.HasRows)

                {
                    while (reader6.Read())
                    {


                        tbxria6.Text = reader6.GetString(0);
                        tbxpro6.Text = reader6.GetString(1);


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

                connect6.Close();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
