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
    public partial class honda : Form
    {
        public honda()
        {
            InitializeComponent();
        }

        private void honda_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            honda2 honda2 = new honda2();
            honda2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            honda3 honda3 = new honda3();
            honda3.Show();
            Visible=false;  
        }
    }
}
