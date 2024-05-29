using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motorcycleshop
{
    public partial class login : Form
    {
        private MySqlConnection con;
        public login()
        {
            InitializeComponent();
            // Set up the connection string
            string connectionString = "server=localhost;port=3306;database=motorcycle;uid=root;password=;";

            // Create MySqlConnection with the connection string
            con = new MySqlConnection(connectionString);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Example hardcoded login credentials
            string correctUsername = "admin";
            string correctPassword = "password123";

            if (username == correctUsername && password == correctPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // You can also open a new form or perform other actions here
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                admin admin = new admin();
                admin.Show();
                Visible = false;

            }
              
                   
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }
    }
}
