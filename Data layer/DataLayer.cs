using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankingApplication.Data_layer
{
    public class DataLayer
    {
        private SqlDataReader sql_datareader;

        public void InsertFund(string acctno,string amount)
        {
            SqlCommand sql_cmd1;
            Utils.con.Open();
            sql_cmd1 = new SqlCommand("DEPOSITFUND", Utils.con);
            sql_cmd1.CommandType = CommandType.StoredProcedure;
            sql_cmd1.Parameters.AddWithValue("@DESTID", SqlDbType.VarChar).Value = acctno;
            sql_cmd1.Parameters.AddWithValue("@AMT", SqlDbType.Float).Value = amount;
            sql_cmd1.ExecuteNonQuery();
            MessageBox.Show("The amount has been deposited");
            Utils.con.Close();
        }

        public string viewAccountName(string acctnum)
        {
            string acctname = "";
            SqlCommand sql_cmd;
                    sql_cmd = Utils.con.CreateCommand();

                    sql_cmd.CommandText = "select FullName from CreateAccount where AccountNumber=" + acctnum;
                    Utils.con.Open();
                    sql_datareader = sql_cmd.ExecuteReader();

                    if (sql_datareader.Read())
                    {
                        acctname = sql_datareader.GetString(0);
                        Utils.con.Close();
                    }
                    else
                    {
                        Utils.con.Close();
                        MessageBox.Show("Search Not Found !", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return acctname;
                }

        public void adminLogin(string uname,string pass,Login login)
        {
            SqlDataAdapter sc1 = new SqlDataAdapter("select * from Admin where USERNAME='" + uname + "' and PASSWORD = '" + pass + "' ", Utils.con);
            DataTable dt = new DataTable();
            sc1.Fill(dt);
            try
            {
                if (dt.Rows.Count == 1)
                {
                    Adminform adminform = new Adminform();
                    adminform.Show();
                    login.Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password are invalid!!.");
                }
            }
            catch
            {

                MessageBox.Show("Connection Error occured!");
            }
        }

        public void customerLogin(string uname, string pass,Customerlogin customerlogin)
        {
            SqlDataAdapter sc1 = new SqlDataAdapter("select * from CustomerAccount where AccountNumber='" + uname + "' and PASSWORD = '" + pass + "' ", Utils.con);
            DataTable dt = new DataTable();
            sc1.Fill(dt);
            try
            {
                if (dt.Rows.Count == 1)
                {
                    User user = new User();
                    user.Show();
                    customerlogin.Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password are invalid!!.");
                }
            }
            catch
            {

                MessageBox.Show("Connection Error occured!");
            }
        }
    }

 }
