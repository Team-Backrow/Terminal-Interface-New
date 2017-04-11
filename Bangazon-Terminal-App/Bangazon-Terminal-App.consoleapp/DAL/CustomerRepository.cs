using Bangazon_Terminal_App.consoleapp.DAL;
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
    class CustomerRepository : ICustomerStorage
    {

        IDbConnection _terminalConnection;

        public CustomerRepository()
        {
            _terminalConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        

        public void AddCustomer(string Name)
        {
            _terminalConnection.Open();

            try
            {
                var addCustomerCommand = _terminalConnection.CreateCommand();
                addCustomerCommand.CommandText = "Insert into Customer(Name) values(@name)";
                var nameParameter = new SqlParameter("name", SqlDbType.VarChar);
                nameParameter.Value = Name;
                addCustomerCommand.Parameters.Add(nameParameter);
                addCustomerCommand.ExecuteNonQuery();
            }
            finally
            {
                _terminalConnection.Close();
            }

        }

        public void GetCustomer(int CustomerID)
        {
            throw new NotImplementedException();
        }
    }
}
