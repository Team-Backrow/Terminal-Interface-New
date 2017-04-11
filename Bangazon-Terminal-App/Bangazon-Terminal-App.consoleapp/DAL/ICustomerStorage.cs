using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp.DAL
{
    interface ICustomerStorage
    {
        void AddCustomer(string Name);
        void GetCustomer(int CustomerID);
    }
}
