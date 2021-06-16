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
    public partial class Withdraw : Form
    {
        // private readonly object con;
        //private object sql_cmd;
        SqlCommand sql_cmd;
        SqlCommand sql_cmd1;
        SqlDataReader sql_datareader;
        public Withdraw()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter the Amount", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                sql_cmd = Utils.con.CreateCommand();

                sql_cmd.CommandText = "select FullName,OpeningBalance from CreateAccount where AccountNumber=" + textBox2.Text;
                Utils.con.Open();
                sql_datareader = sql_cmd.ExecuteReader();

                if (sql_datareader.Read())
                {
                    textBox3.Text = sql_datareader.GetString(0);
                    textBox4.Text = sql_datareader.GetDouble(1).ToString();
                    Utils.con.Close();
                }
                else
                {
                    Utils.con.Close();
                    MessageBox.Show("Search Not Found !", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(textBox1.Text)) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill the missing field !", "Field Not Fill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Utils.con.Close();

                Utils.con.Open();


                //   sql_cmd1 = con.CreateCommand();


                sql_cmd1 = new SqlCommand("WITHDRAW", Utils.con);
                sql_cmd1.CommandType = CommandType.StoredProcedure;
                sql_cmd1.Parameters.AddWithValue("@DESTID", SqlDbType.VarChar).Value = textBox2.Text.Trim();
                sql_cmd1.Parameters.AddWithValue("@WAMT", SqlDbType.Float).Value = textBox1.Text.Trim();
                sql_cmd1.ExecuteNonQuery();
                MessageBox.Show("The amount has been withdraw successfully");
                Utils.con.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
 }
