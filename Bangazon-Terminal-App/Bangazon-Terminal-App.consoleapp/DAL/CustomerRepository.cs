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


        public void AddCustomer( string Name, string StreetAddress, string City, string State, int Zip, int Phone)

        {
            _terminalConnection.Open();

            try
            {
                var addCustomerCommand = _terminalConnection.CreateCommand();
                addCustomerCommand.CommandText = "Insert into Customer(Name, StreetAddress, City, State, Zip, Phone) values(@name, @address, @city, @state, @zip, @phone)";


                var nameParameter = new SqlParameter("name", SqlDbType.VarChar);
                nameParameter.Value = Name;
                addCustomerCommand.Parameters.Add(nameParameter);

                var addressParameter = new SqlParameter("address", SqlDbType.VarChar);
                addressParameter.Value = StreetAddress;
                addCustomerCommand.Parameters.Add(addressParameter);

                var cityParameter = new SqlParameter("city", SqlDbType.VarChar);
                cityParameter.Value = City;
                addCustomerCommand.Parameters.Add(cityParameter);

                var stateParameter = new SqlParameter("state", SqlDbType.VarChar);
                stateParameter.Value = State;
                addCustomerCommand.Parameters.Add(stateParameter);

                var zipParameter = new SqlParameter("zip", SqlDbType.Int);
                zipParameter.Value = Zip;
                addCustomerCommand.Parameters.Add(zipParameter);

                var phoneParameter = new SqlParameter("phone", SqlDbType.Int);
                phoneParameter.Value = Phone;
                addCustomerCommand.Parameters.Add(phoneParameter);

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
