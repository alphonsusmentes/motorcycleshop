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
    public partial class suzuki2 : Form
    {
        public suzuki2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suzuki suzuki = new suzuki();
            suzuki.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raider raider = new raider();
            raider.Show();
            Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            smash smash = new smash();
            smash.Show();
            Visible=false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shooter shooter = new shooter();
            shooter.Show();
            Visible=false;
        }
    }
}
