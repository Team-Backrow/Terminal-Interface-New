using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace Bangazon_Terminal_App.consoleapp
{
    public class Customer
    {
  
            public int CustomerID { get; set; }

            public string Name { get; set; }

            public string StreetAddress { get; set; }
            
            public string City { get; set; }

            public string State { get; set; }

            public int Zip { get; set; }

            public int Phone { get; set; }

        }
    }
