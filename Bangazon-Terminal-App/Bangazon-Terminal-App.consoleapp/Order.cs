using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
