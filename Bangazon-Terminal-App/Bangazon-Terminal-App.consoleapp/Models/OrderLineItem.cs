using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp.Models
{
    class OrderLineItem
    {
        public int OrderLineItemID { get; set; }
  
         public int OrderID { get; set; }
  
         public int ProductID { get; set; }
  
         public decimal Price { get; set; }
    }
}
