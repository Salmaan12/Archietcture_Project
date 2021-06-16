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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DataLayer().adminLogin(username.Text.Trim(),password.Text.Trim(),this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selection selection = new Selection();
            selection.Show();
            this.Hide();
        }
    }
}
