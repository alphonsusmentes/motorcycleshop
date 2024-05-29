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
    public partial class honda2 : Form
    {
        public honda2()
        {
            InitializeComponent();
        }

        private void honda2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            honda honda = new honda();
            honda.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmx125 tmx125 = new tmx125();
            tmx125.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CBR150R CBR150R = new CBR150R();
            CBR150R.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CB150X CB150X = new CB150X();
            CB150X.Show();
            Visible = false;    
        }
    }
}
