﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp.DAL
{
    public interface ICustomerStorage
    {
        Customer AddCustomer( string Name, string StreetAddress, string City, string State, int Zip, int Phone);

        List<Customer> GetCustomers(); 

        
    }
}
