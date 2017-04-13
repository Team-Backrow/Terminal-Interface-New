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
        public Customer activeCustomer { get; set; }

            [Key]
            public int CustomerID { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string StreetAddress { get; set; }
            
            [Required]
            public string City { get; set; }

            [Required]
            public string State { get; set; }

            [Required]
            public int Zip { get; set; }

            public int Phone { get; set; }


        }
    }
