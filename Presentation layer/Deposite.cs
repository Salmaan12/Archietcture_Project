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
    public partial class Deposite : Form
    {
        
       // private readonly object con;
        //private object sql_cmd;
        // SqlCommand sql_cmd;
        // SqlCommand sql_cmd1;
        // SqlDataReader sql_datareader;

        public Deposite()
        {
            InitializeComponent();
            back.Tag = "back";
            back.Click += ClickEvent;

            button1.Tag = "button1";
            button1.Click += ClickEvent;
        }

        private void Deposite_Load(object sender, EventArgs e)
        {
            
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            if (tag == "back")
            {
                User user = new User();
                user.Show();
                this.Hide();
            }
            else if(tag == "button1")
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Please enter the Amount", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    textBox3.Text = new DataLayer().viewAccountName(textBox2.Text.Trim());
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void depositebtn_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                MessageBox.Show("Please fill the missing field !", "Field Not Fill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new DataLayer().InsertFund(textBox1.Text.Trim(), textBox2.Text.Trim());
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
