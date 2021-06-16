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
    public partial class BalanceCheck : Customerlogin
    {
        // private readonly object con;
        //private object sql_cmd;
        SqlCommand sql_cmd;
        SqlDataReader sql_datareader;
        public BalanceCheck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            user.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the Account Number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                sql_cmd = Utils.con.CreateCommand();

                sql_cmd.CommandText = "select OpeningBalance from CreateAccount where AccountNumber=" + textBox1.Text;
                Utils.con.Open();
                sql_datareader = sql_cmd.ExecuteReader();

                if (sql_datareader.Read())
                {
                    textBox2.Text = sql_datareader.GetDouble(0).ToString();
                    Utils.con.Close();
                }
                else
                {
                    Utils.con.Close();
                    MessageBox.Show("Search Not Found !", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
