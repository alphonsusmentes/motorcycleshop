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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yamaha f3 = new yamaha();
            f3.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            honda f9 = new honda();
            f9.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kawasaki2 kawasaki2 = new kawasaki2();
            kawasaki2.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            suzuki suzuki = new suzuki();
            suzuki.Show();
            Visible=false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            Visible=false;
        }
    }
}
