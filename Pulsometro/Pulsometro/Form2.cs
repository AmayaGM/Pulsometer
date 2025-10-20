using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;

namespace Pulsometro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Ingresa tu nombre";
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = "Ingresa tu contraseña";
            textBox3.ForeColor = Color.Gray;
            textBox3.Text = "Ingresa tu edad";
            textBox4.ForeColor = Color.Gray;
            textBox4.Text = "Ingresa tu sexo M ó F";
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myconnection = new MySqlConnection("SERVER=localhost;DATABASE=pulso;UID=root;PASSWORD=;");

            try
            {
                myconnection.Open();
            }
            catch(MySqlException ex) {
                MessageBox.Show("Error " + ex.ToString());
                throw;
            }

            String query = "INSERT INTO `user`(`idUser`, `nomUser`, `passUser`, `edad`, `genero`) VALUES('', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
            MySqlCommand mycommand = new MySqlCommand(query, myconnection);
            try {
                mycommand.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado");

                Form3 frm3 = new Form3();
                frm3.label8.Text = textBox1.Text;
                frm3.Show();
                this.Dispose(false);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }

            try
            {
                myconnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
                throw;
            }




        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            textBox2.PasswordChar = '*';
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.ForeColor = Color.Black;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
