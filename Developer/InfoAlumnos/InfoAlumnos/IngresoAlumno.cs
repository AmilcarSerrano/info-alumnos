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
using MySql.Data;


namespace InfoAlumnos
{
    public partial class IngresoAlumno : Form
    {
        public IngresoAlumno()
        {
            InitializeComponent();
        }

        private void btnIngresarAlum_Click(object sender, EventArgs e)
        {
            Loggin(tbxUsuario.Text, tbxContraseña.Text);



        }
        public void Loggin(string matricula, string contraseña)
        {
            try
            {
                MySqlConnection connect = Conexión.ObtenerConexión();
                connect.Open();
                MySqlCommand comand = new MySqlCommand("SELECT *FROM Alumnos WHERE matricula = @matricula AND Contrasena = @Pas", connect);
                comand.Parameters.AddWithValue("matricula", matricula);
                comand.Parameters.AddWithValue("Pas", contraseña);
                MySqlDataAdapter sda = new MySqlDataAdapter(comand);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MenúAlumno MenAlum = new MenúAlumno();
                    this.Hide();
                    MenAlum.Show();
                    MenAlum.txtID.Text = tbxUsuario.Text;
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña  Incorrecta");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                MySqlConnection connect = Conexión.ObtenerConexión();
                connect.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroAlum RegAlum = new RegistroAlum();
            this.Hide();
            RegAlum.Show();
            
        }

        private void IngresoAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
