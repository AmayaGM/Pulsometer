using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace Pulsometro
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            label4.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Dispose(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {


            //Conexion e inserccion en bd
            MySqlConnection myconnection = new MySqlConnection("SERVER=localhost;DATABASE=pulso;UID=root;PASSWORD=;");

            try
            {
                myconnection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
                throw;
            }

            String query = "SELECT `idUser` FROM `user` WHERE `nomUser`='" + label4.Text + "';";
            MySqlCommand mycommand = new MySqlCommand(query, myconnection);
            int iduser = (int)mycommand.ExecuteScalar();


            String query2 = "SELECT `frecuencia`, `fecha`, `clasificacion` FROM `historial` WHERE `idUser2`=" + iduser + ";";
            MySqlCommand mycommand2 = new MySqlCommand(query2, myconnection);

            MySqlDataAdapter myc3 = new MySqlDataAdapter(mycommand2);

            DataTable tabla = new DataTable();
            myc3.Fill(tabla);
            dataGridView1.DataSource = tabla;


            myconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        
    

    }
}
