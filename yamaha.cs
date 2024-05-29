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
    public partial class yamaha : Form
    {
        public yamaha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yamaha2 f4 = new yamaha2();
            f4.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yamaha3 f8 = new yamaha3();
            f8.Show();
            Visible = false;
        }
    }
}
