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
    public partial class yamaha3 : Form
    {
        public yamaha3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mio125 f7 = new mio125();
            f7.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yamaha yamaha = new yamaha();
            yamaha.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FAZZIO FAZZIO= new FAZZIO();
            FAZZIO.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AEROX AEROX = new AEROX();  
            AEROX.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GRAVIS GRAVIS = new GRAVIS();  
            GRAVIS.Show();
            Visible=false;
        }
    }
}
