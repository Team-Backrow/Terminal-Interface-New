using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp.DAL
{
    interface IPaymentStorage
    {
        void AddPayment(int PaymentTypeID);
        void GetPayment(int PaymentTypeID);
    }
}
