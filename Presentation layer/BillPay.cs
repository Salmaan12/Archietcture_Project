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
    public partial class BillPay : Form
    {
        public BillPay()
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

            if ((string.IsNullOrWhiteSpace(textBox2.Text)) || (string.IsNullOrWhiteSpace(comboBox1.Text)) || (string.IsNullOrWhiteSpace(accnum.Text)))
            {
                MessageBox.Show("Please fill the missing field !", "Field Not Fill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlDataAdapter sc1 = new SqlDataAdapter("INSERT INTO BillPayment(ConsumerNumber,[BillType],AccountNum) VALUES ('" + textBox2.Text + "','" + comboBox1.Text + "','" + accnum.Text + "')", Utils.con);
                DataTable dt = new DataTable();
                sc1.Fill(dt);
                try
                {
                    MessageBox.Show("Your Request has been submitted for further procedure!!.");
                }
                catch
                {
                    MessageBox.Show("Connection Error occured!");
                }
            }
        }
    }
}
