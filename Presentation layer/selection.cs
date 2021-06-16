using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankingApplication
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            Customerlogin customerlogin = new Customerlogin();
            customerlogin.Show();
            this.Hide();
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            Login adminLogin = new Login();
            adminLogin.Show();
            this.Hide();
        }
    }
}
