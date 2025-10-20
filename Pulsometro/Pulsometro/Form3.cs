using K4os.Compression.LZ4.Internal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Pulsometro
{

    public partial class Form3 : Form
    {
        //Comunicacion con arduino
        System.IO.Ports.SerialPort Arduino;

        public Form3()
        {
            InitializeComponent();
            label8.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 frm4 = new Form4();
            frm4.label4.Text = label8.Text;
            frm4.Show();
            this.Dispose(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //objeto para la clase del puerto serial ;
            Arduino = new System.IO.Ports.SerialPort();
            //Puerto al que se quiere acceder
            Arduino.PortName = "COM3";
            Arduino.BaudRate = 9600;
            Arduino.Open();
            //leer datos)
             String labelPulso = Arduino.ReadLine();
              label3.Text = labelPulso;

            Arduino.Close();

            DateTime fecha = DateTime.Now;
            label6.Text = fecha.ToString();
            
    
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

            String query = "SELECT `edad` FROM `user` WHERE `nomUser`='" + label8.Text + "';";
            MySqlCommand mycommand = new MySqlCommand(query, myconnection);
            int edaduser = (int)mycommand.ExecuteScalar();

            String query2 = "SELECT `genero` FROM `user` WHERE `nomUser`='" + label8.Text + "';";
            MySqlCommand mycommand2 = new MySqlCommand(query2, myconnection);
            String sexouser = (String)mycommand2.ExecuteScalar();

            

            char su2 = Convert.ToChar(sexouser);
            float pulsol2 = float.Parse(labelPulso);

            if (su2=='M')
            {
                if (edaduser<=29) {
                    if(pulsol2<=60) {
                        label5.ForeColor = Color.Blue;
                        label5.Text = "Excelente"; 
                    }
                    else if (pulsol2 <= 68)
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "Bueno";
                    }
                    else if (pulsol2 <= 84)
                    {
                        label5.ForeColor = Color.Yellow;
                        label5.Text = "Normal";
                    }
                    else 
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inadecuado";
                    }
                }
                else if (edaduser<=39){
                    if (pulsol2 <= 62)
                    {
                        label5.ForeColor = Color.Blue;
                        label5.Text = "Excelente";
                    }
                    else if (pulsol2 <= 70)
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "Bueno";
                    }
                    else if (pulsol2 <= 84)
                    {
                        label5.ForeColor = Color.Yellow;
                        label5.Text = "Normal";
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inadecuado";
                    }
                }
                else if (edaduser <= 49) {
                    if (pulsol2 <= 64)
                    {
                        label5.ForeColor = Color.Blue;
                        label5.Text = "Excelente";
                    }
                    else if (pulsol2 <= 72)
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "Bueno";
                    }
                    else if (pulsol2 <= 88)
                    {
                        label5.ForeColor = Color.Yellow;
                        label5.Text = "Normal";
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inadecuado";
                    }
                }
                else {
                    if (pulsol2 <= 66)
                    {
                        label5.ForeColor = Color.Blue;
                        label5.Text = "Excelente";
                    }
                    else if (pulsol2 <= 74)
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "Bueno";
                    }
                    else if (pulsol2 <= 88)
                    {
                        label5.ForeColor = Color.Yellow;
                        label5.Text = "Normal";
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inadecuado";
                    }
                }
            }
            else {
                if (edaduser <= 29) {
                    if (pulsol2 <= 70)
                    {
                        label5.ForeColor = Color.Blue;
                        label5.Text = "Excelente";
                    }
                    else if (pulsol2 <= 76)
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "Bueno";
                    }
                    else if (pulsol2 <= 94)
                    {
                        label5.ForeColor = Color.Yellow;
                        label5.Text = "Normal";
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inadecuado";
                    }
                }
                else if (edaduser <= 39) {
                    if (pulsol2 <= 70)
                    {
                        label5.ForeColor = Color.Blue;
                        label5.Text = "Excelente";
                    }
                    else if (pulsol2 <= 78)
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "Bueno";
                    }
                    else if (pulsol2 <= 96)
                    {
                        label5.ForeColor = Color.Yellow;
                        label5.Text = "Normal";
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inadecuado";
                    }
                }
                else if (edaduser <= 49) {
                    if (pulsol2 <= 72)
                    {
                        label5.ForeColor = Color.Blue;
                        label5.Text = "Excelente";
                    }
                    else if (pulsol2 <= 78)
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "Bueno";
                    }
                    else if (pulsol2 <= 98)
                    {
                        label5.ForeColor = Color.Yellow;
                        label5.Text = "Normal";
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inadecuado";
                    }
                }
                else {
                    if (pulsol2 <= 74)
                    {
                        label5.ForeColor = Color.Blue;
                        label5.Text = "Excelente";
                    }
                    else if (pulsol2 <= 82)
                    {
                        label5.ForeColor = Color.Green;
                        label5.Text = "Bueno";
                    }
                    else if (pulsol2 <= 102)
                    {
                        label5.ForeColor = Color.Yellow;
                        label5.Text = "Normal";
                    }
                    else
                    {
                        label5.ForeColor = Color.Red;
                        label5.Text = "Inadecuado";
                    }
                }
            }

            

            myconnection.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
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

            String query = "SELECT `idUser` FROM `user` WHERE `nomUser`='" + label8.Text+ "';";
            MySqlCommand mycommand = new MySqlCommand(query, myconnection);
            int iduser = (int)mycommand.ExecuteScalar();


            String query2 = "INSERT INTO `historial`(`idUser2`, `idReg`, `frecuencia`, `fecha`, `clasificacion`) VALUES ('"+iduser+"','','"+label3.Text+"','"+label6.Text+"','"+label5.Text+"')";
            MySqlCommand mycommand2 = new MySqlCommand(query2, myconnection);

            

            try
            {
                mycommand2.ExecuteNonQuery();
                MessageBox.Show("BPM registrado!!!");



            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }

            myconnection.Close();

        }
    }
}
