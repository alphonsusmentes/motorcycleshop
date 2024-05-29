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
    public partial class BEAT : Form
    {
        public BEAT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.textBox1.Text = label3.Text;
            f6.textBox6.Text = label4.Text;
            f6.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            honda3 honda3 = new honda3();
            honda3.Show();
            Visible=false;
        }
    }
}
