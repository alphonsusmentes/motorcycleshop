using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace motorcycleshop
{
    public partial class Form6 : Form
    {
        
        public Form6()
        {
            InitializeComponent();
            
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double total_amount = double.Parse(textBox1.Text);
            Double downpayment = double.Parse(textBox2.Text);
            textBox4.Text ="(1 Year) Php"+ Math.Round((total_amount - downpayment) / 12,0).ToString();
            textBox3.Text ="(2 Years) Php"+ Math.Round((total_amount - downpayment) / 24,0).ToString();
            textBox5.Text ="(3 Years) Php"+ Math.Round((total_amount - downpayment) / 36,0).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            details details = new details();
            details.textBox6.Text = textBox1.Text;
            details.textBox5.Text = textBox4.Text;
            details.textBox7.Text = textBox2.Text;
            details.textBox8.Text = textBox6.Text;
            details.Show();
            Visible = false;
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

         private void button4_Click(object sender, EventArgs e)
        {
            details details = new details();
            details.textBox6.Text = textBox1.Text;
            details.textBox5.Text = textBox3.Text;
            details.textBox7.Text = textBox2.Text;
            details.textBox8.Text = textBox6.Text;
            details.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            details details = new details();
            details.textBox6.Text = textBox1.Text;
            details.textBox5.Text = textBox5.Text;
            details.textBox7.Text = textBox2.Text;
            details.textBox8.Text = textBox6.Text;
            details.Show();
            Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
