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
        public void AddPayment(string PaymentType, string AccountNumber)
        {
            _terminalConnection.Open();

            try
            {
                var addPaymentCommand = _terminalConnection.CreateCommand();
                addPaymentCommand.CommandText = "Insert into PaymentType(PaymentType, AccountNumber, CustomerId) values(@type, @accountnum, @customer)";


                var paymentTypeParameter = new SqlParameter("type", SqlDbType.VarChar);
                paymentTypeParameter.Value = PaymentType;
                addPaymentCommand.Parameters.Add(paymentTypeParameter);

                var accountNumberParameter = new SqlParameter("accountnum", SqlDbType.VarChar);
                accountNumberParameter.Value = AccountNumber;
                addPaymentCommand.Parameters.Add(accountNumberParameter);

                addPaymentCommand.ExecuteNonQuery();
            }
            finally
            {
                _terminalConnection.Close();
            }

        }

        public void GetPayment(int PaymentTypeID)
        {
            throw new NotImplementedException();
        }
    }
}
