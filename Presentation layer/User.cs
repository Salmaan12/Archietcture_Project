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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void depositeCash_Click(object sender, EventArgs e)
        {
            Deposite deposite = new Deposite();
            deposite.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BalanceCheck balanceCheck = new BalanceCheck();
            balanceCheck.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BillPay billPay = new BillPay();
            billPay.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoneyTransfer moneyTransfer = new MoneyTransfer();
            moneyTransfer.Show();
            this.Hide();
        }
    }
}
