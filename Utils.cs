using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApplication
{
    public class Utils
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=SALMAN-PERSONAL\SQLEXPRESS;Initial Catalog=SCDPROJECT;Integrated Security=True");
    }
}
