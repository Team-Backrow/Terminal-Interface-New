using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp.Models
{   
    class Payment
{

    public int PaymentID { get; set; }

    public int PaymentType { get; set; }

    public int AccountNo { get; set; }

    public int CustomerID { get; set; }
    }
}
