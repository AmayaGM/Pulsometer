using MySql.Data.MySqlClient;

namespace Pulsometro
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Ingresa tu nombre";
            textBox2.ForeColor = Color.Gray;
            textBox2.Text = "Ingresa tu contraseña";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Dispose(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            String query = "SELECT `idUser` FROM `user` WHERE `nomUser`='" + textBox1.Text+"' && `passUser`='"+textBox2.Text+"';";
            MySqlCommand mycommand = new MySqlCommand(query, myconnection);
            int iduser = Convert.ToInt32(mycommand.ExecuteScalar());

            try
            {
                mycommand.ExecuteNonQuery();
                if (iduser == 0)
                {
                    MessageBox.Show("Usuario no encontrado!!");
                }
                else
                {
                    MessageBox.Show("Usuario encontrado!!");
                    
                    Form3 frm3 = new Form3();
                    frm3.label8.Text = textBox1.Text;
                    frm3.Show();
                    this.Dispose(false);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }

            
                myconnection.Close();
            


        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Enter(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}