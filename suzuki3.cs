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
    public partial class suzuki3 : Form
    {
        public suzuki3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addres addres = new addres();
            addres.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suzuki suzuki = new suzuki();
            suzuki.Show();
            Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            skydrive skydrive = new skydrive();
            skydrive.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            burgman burgman = new burgman();
            burgman.Show();
            Visible = false;
        }
    }
}
