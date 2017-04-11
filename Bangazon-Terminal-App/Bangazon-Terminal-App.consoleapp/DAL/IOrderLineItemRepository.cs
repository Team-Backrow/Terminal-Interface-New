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
    class IOrderLineItemRepository : IOrderLineItemStorage
    {
        IDbConnection _terminalConnection;

        public IOrderLineItemRepository()
        {
            _terminalConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public void AddOrderLineItem(int OrderLineItemID)
        {
            throw new NotImplementedException();
        }

        public void GetOrderLineItem(int OrderLineItemID)
        {
            throw new NotImplementedException();
        }
    }
}
