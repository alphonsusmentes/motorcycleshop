﻿using System;
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
    public partial class CB150X : Form
    {
        public CB150X()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.textBox1.Text = label2.Text;
            f6.textBox6.Text = label3.Text;
            f6.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            honda2 honda2 = new honda2();
            honda2.Show();
            Visible = false;
        }
    }
}
