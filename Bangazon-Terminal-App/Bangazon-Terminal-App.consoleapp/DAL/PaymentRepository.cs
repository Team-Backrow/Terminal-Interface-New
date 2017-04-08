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

    class PaymentRepository : IPaymentStorage
    {
        IDbConnection _terminalConnection;

        public PaymentRepository()
        {
            _terminalConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
        public void AddPayment(int PaymentTypeID)
        {
            throw new NotImplementedException();
        }

        public void GetPayment(int PaymentTypeID)
        {
            throw new NotImplementedException();
        }
    }
}
