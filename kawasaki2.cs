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
    public partial class kawasaki2 : Form
    {
        public kawasaki2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DOMINAR DOMINAR = new DOMINAR();
            DOMINAR.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rouser rouser = new rouser();
            rouser.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ninja ninja = new ninja();
            ninja.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible=false;
        }
    }
}
