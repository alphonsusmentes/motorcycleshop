using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motorcycleshop
{
    public partial class honda3 : Form
    {
        public honda3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DIO DIO=new DIO();
            DIO.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BEAT BEAT=new BEAT();
            BEAT.Show();
            Visible=false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CLICK CLICK=new CLICK();
            CLICK.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            honda honda = new honda();
            honda.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PCX PCX=new PCX();
            PCX.Show();
            Visible = false;
        }
    }
}
