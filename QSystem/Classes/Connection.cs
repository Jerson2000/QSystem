using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QSystem.Classes
{
    public class Connection
    {
        public static SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-F25K07A\SQLEXPRESS;Initial Catalog=QSystem;Integrated Security=True");
    }
}
