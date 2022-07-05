using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatihCdCenter.Core
{
    public static class Connection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=FATIH\\LOCAL1;Initial Catalog=FatihCdCenter;Integrated Security=True");
        }
    }
}
