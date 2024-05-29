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
    public partial class admin1 : UserControl

    {
        public int OrderId { get; set; }


        public string Fullname
        {
            get { return fullname.Text; }
            set { fullname.Text = value; }
        }

        public string Age
        {
            get { return age.Text; }
            set { age.Text = value; }
        }
        public string Address
        {
            get { return address.Text; }
            set { address.Text = value; }
        }
        public string contactnumber
        {
            get { return Contactnumber.Text; }
            set { Contactnumber.Text = value; }
        }
        public string motormodel
        {
            get { return MotorModel.Text; }
            set { MotorModel.Text = value; }
        }
        public string payment
        {
            get { return Payment.Text; }
            set { Payment.Text = value; }
        }
        public string Monthly
        {
            get { return monthly.Text; }
            set { monthly.Text = value; }
        }
        public string Price
        {
            get { return price.Text; }
            set { price.Text = value; }
        }
        public string Down
        {
            get { return down.Text; }
            set { down.Text = value; }
        }









        public admin1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin1_Load(object sender, EventArgs e)
        {

        }

        private void Payment_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator7_Click(object sender, EventArgs e)
        {

        }
    }
}
