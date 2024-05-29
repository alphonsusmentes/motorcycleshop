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

namespace motorcycleshop
{
    public partial class admin : Form
    {
        private MySqlConnection con;
        public admin()
        {
            InitializeComponent();

            string connectionString = "server=localhost;port=3306;database=motorcycle;uid=root;password=;";


            con = new MySqlConnection(connectionString);
        }
        public void Reload()
        { 
            FetchData();
        
        
        }
        private void FetchData()
        {

            flow.Controls.Clear();
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand($"SELECT Fullname, Age, Address, Contact_number, Motor_Model, Mode_of_Payment, Monthly_Payment, Motor_Price, Down_Payment FROM order_details", con);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        admin1 orderdetails = new admin1();
                        orderdetails.Fullname = reader["Fullname"].ToString();
                        orderdetails.Age = reader["Age"].ToString();
                        orderdetails.Address = reader["Address"].ToString();
                        orderdetails.contactnumber = reader["Contact_number"].ToString();
                        orderdetails.motormodel = reader["Motor_Model"].ToString();
                        orderdetails.payment = reader["Mode_Of_Payment"].ToString();
                        orderdetails.Monthly = reader["Monthly_Payment"].ToString();
                        orderdetails.Price = reader["Motor_Price"].ToString();
                        orderdetails.Down = reader["Down_Payment"].ToString();

                        flow.Controls.Add(orderdetails);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            FetchData();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }
    }
}
