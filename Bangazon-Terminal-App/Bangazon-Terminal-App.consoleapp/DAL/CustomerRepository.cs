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
        Customer activeCustomer = new Customer();

        IDbConnection _terminalConnection;

        public CustomerRepository()
        {
            _terminalConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }


        public Customer AddCustomer( string Name, string StreetAddress, string City, string State, int Zip, int Phone)

        {
            _terminalConnection.Open();

            try
            {
                var addCustomerCommand = _terminalConnection.CreateCommand();
                addCustomerCommand.CommandText = "Insert into Customer(Name, StreetAddress, City, State, Zip, Phone) values(@name, @address, @city, @state, @zip, @phone) Select SCOPE_IDENTITY()";


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

                var reader = addCustomerCommand.ExecuteScalar();
                if (reader != null)
                {
                    var id = reader.ToString();
                     activeCustomer.CustomerID = Convert.ToInt32(id);
                     activeCustomer.Name = Name;
                    

                    //Console.WriteLine("Your Name is " + userFirstName + userLastName);
                    //Console.WriteLine("Your Address is " + userStreet);
                    //Console.WriteLine(userCity + userState + userZipCode);

                    Console.WriteLine("Record inserted successfully ID = " + id);
                    //Console.WriteLine(_newCustomer.CustomerId);
                }
                return activeCustomer;

            }
            finally
            {
                _terminalConnection.Close();
            }

        }

        public List<Customer> GetCustomers()
        {
            _terminalConnection.Open();

            try
            {
                var getCustomerCommand = _terminalConnection.CreateCommand();
                getCustomerCommand.CommandText = "SELECT CustomerID,Name FROM Customer";

                var reader = getCustomerCommand.ExecuteReader();

                var customerList = new List<Customer>();
                while (reader.Read())
                {
                    var customer = new Customer
                    {
                        CustomerID = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };
                    customerList.Add(customer);
                }
                return customerList;
            }
            finally
            {
                _terminalConnection.Close();
            }

        }
    }
}
