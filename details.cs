using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace motorcycleshop
{
    public partial class details : Form
    {
        
        private MySqlConnection con;
        public details()
            
        {
            InitializeComponent();
            
            
             
            
            
            

            // Set up the connection string
            string connectionString = "server=localhost;port=3306;database=motorcycle;uid=root;password=;";

            // Create MySqlConnection with the connection string
            con = new MySqlConnection(connectionString);

            // Populate the ComboBox with payment modes
            PopulatePaymentModesComboBox();

            // Set ComboBox dropdown style to DropDownList
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PopulatePaymentModesComboBox()
        {
            // Define the payment modes
            List<string> paymentModes = new List<string> { "cash", "debit card", "credit card" };

            // Clear existing items (in case of reloading)
            comboBox1.Items.Clear();

            // Add payment modes to the ComboBox
            comboBox1.Items.AddRange(paymentModes.ToArray());

            // Select the first item by default
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            // Open the connection
            con.Open();

            try
            {
                // Define the SQL query with parameters
                string query = "INSERT INTO order_details (Fullname, Age, Address, Contact_Number, Mode_of_Payment, Monthly_Payment, Motor_Price, Down_Payment, Motor_Model) " +
                               "VALUES (@FullName, @Age, @Address, @ContactNumber, @ModeOfPayment, @MonthlyPayment, @MotorPrice, @DownPayment, @MotorModel)";

                // Create MySqlCommand object with the query and connection
                MySqlCommand cmd = new MySqlCommand(query, con);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                cmd.Parameters.AddWithValue("@Age", textBox2.Text);
                cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", textBox4.Text);
                cmd.Parameters.AddWithValue("@MonthlyPayment", textBox5.Text);
                cmd.Parameters.AddWithValue("@MotorPrice", textBox6.Text);
                cmd.Parameters.AddWithValue("@DownPayment", textBox7.Text);
                cmd.Parameters.AddWithValue("@MotorModel", textBox8.Text);
                
                // Get selected payment mode from ComboBox
                string selectedPaymentMode = comboBox1.SelectedItem?.ToString() ?? "";
                cmd.Parameters.AddWithValue("@ModeOfPayment", selectedPaymentMode);

                // Execute the command (insert operation)
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    admin admin = new admin();
                    admin.Reload();


                    // If successful, show Form3
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to insert data into the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show Form2
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

         private void details_Load(object sender, EventArgs e)
        {
            


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
