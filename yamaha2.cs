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
    public partial class yamaha2 : Form
    {
        public yamaha2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ytx125 f5 = new ytx125();
            f5.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yamaha f3 = new yamaha();
            f3.Show();
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SZ150 sz150 = new SZ150();
            sz150.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SNIPER150 sniper150 = new SNIPER150();
            sniper150.Show();
            Visible = false;
        }
    }
}
