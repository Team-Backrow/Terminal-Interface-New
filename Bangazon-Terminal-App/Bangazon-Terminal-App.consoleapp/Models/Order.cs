using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp.Models
{
    class Order
    {
       
        public int OrderID { get; set; }

        public int PaymentID { get; set; }

        public int CustomerID { get; set; }
    }
}
