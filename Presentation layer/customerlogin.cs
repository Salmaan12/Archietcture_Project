using bankingApplication.Data_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankingApplication
{
    public partial class Customerlogin : Form
    {
        string acctnumber = "";
        public Customerlogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selection selection = new Selection();
            selection.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DataLayer().customerLogin(acctnumber, password.Text.Trim(), this);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            acctnumber = username.Text.Trim();
        }
    }
 }
