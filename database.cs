using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
namespace motorcycleshop
{
    public partial class database : Form
    {
        public database()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=motorcycle; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try{
                mySqlConnection.Open();
                MessageBox.Show("Connection success");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
