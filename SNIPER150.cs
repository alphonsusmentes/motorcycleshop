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
    public partial class SNIPER150 : Form
    {
        public SNIPER150()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.textBox1.Text = label2.Text;
            f6.textBox6.Text = label3.Text;
            f6.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yamaha2 yamaha2 = new yamaha2();
            yamaha2.Show();
            Visible = false;

        }
    }
}
