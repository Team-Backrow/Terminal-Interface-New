using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp.DAL
{
    interface IOrderLineItemStorage
    { 
        void AddOrderLineItem(int OrderLineItemID);
        void GetOrderLineItem(int OrderLineItemID);
    }
}
