using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Bangazon_Terminal_App.consoleapp
{
    public class Customer
    {
        IDbConnection _terminalConnection;

        public Customer()
    {

            _terminalConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
             
                
                
                //  SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

    }
  }
}
