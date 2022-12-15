using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=JASPHER\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";
            return con;
        }
    }
}
