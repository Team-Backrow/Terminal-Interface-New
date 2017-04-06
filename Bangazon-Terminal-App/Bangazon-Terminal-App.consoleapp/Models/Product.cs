using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp
{
    class Product
    {
        [Key]

        public int ProductID { get; set; }

        [Required]
        public int PaymentID  {get; set; }

        [Required]
        public int PaymentType  {get; set; }

        [Required]
        public int AccountNo {get; set; }

        [Required]
        public int CustomerID { get; set; }

    }
}
