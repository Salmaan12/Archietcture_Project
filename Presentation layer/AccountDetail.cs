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
    public partial class AccountDetail : Form
    {

        public AccountDetail()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminform adminform = new Adminform();
            adminform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sd = new SqlDataAdapter("select * from CreateAccount", Utils.con);
            DataTable dtaa = new DataTable();
            sd.Fill(dtaa);
            dataGridView1.DataSource = dtaa;
        }
    }
}
